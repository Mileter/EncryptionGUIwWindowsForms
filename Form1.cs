using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptionGUIwWindowsForms
{
    public partial class MainWindow : Form
    {
        public bool hasOperationStarted = false;
        private Dictionary<string, bool> completion =
            new Dictionary<string, bool>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            completion["password"] = false;
            completion["type"] = false;
            completion["input"] = false;
            completion["output"] = false;

            ReadSpeed.Minimum = 0;
            ReadSpeed.Maximum = 1024;

            CompletionChanged();
        }

        private void InputFilePickButton_Click(object sender, EventArgs e)
        {
            InputFilePicker.ShowDialog(this);
        }

        private void OutputFilePickButton_Click(object sender, EventArgs e)
        {
            OutputFilePicker.ShowDialog(this);
        }

        private bool canceled = false;

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (hasOperationStarted && StartStopButton.Text != "Start")
            {
                StartStopButton.Text = "Stopping...";
                StartStopButton.Enabled = false;

                canceled = true;
                while (canceled) ;

                StartStopButton.Text = "Start";
                StartStopButton.Enabled = true;

                QuitButton.Enabled = true;
            }
            else
            {
                StartStopButton.Text = "Stop";
                QuitButton.Enabled = false;

                string inputFilename = InputFilePath.Text;
                string outputFilename = OutputFilePath.Text;
                string password = PasswordField.Text;
                PasswordField.Text = ""; // clear password field
                bool isOperationTypeEncryption = EncryptRadial.Checked;
                byte[] passwordHash;

                using (SHA256 passwordHasher = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    passwordHash = passwordHasher.ComputeHash(passwordBytes);
                    password = ""; // no prob after done with
                }

                AES256helper(inputFilename, outputFilename, isOperationTypeEncryption, passwordHash);
            }
            hasOperationStarted = !hasOperationStarted;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            if(PasswordField.Text != "")
                completion["password"] = true;
            else
                completion["password"] = false;
            CompletionChanged();
        }

        private void InputFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if(!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                if(((string[])e.Data.GetData(DataFormats.FileDrop)).Length == 1)
                    e.Effect = DragDropEffects.Link;
            }
        }

        private void InputFilePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                InputFilePath.Text = files[0];

                completion["input"] = true;
                CompletionChanged();
            }
        }

        private void InputFilePicker_FileOk(object sender, CancelEventArgs e)
        {
            InputFilePath.Text = InputFilePicker.FileName;
            completion["input"] = true;
            if (!File.Exists(InputFilePicker.FileName))
            {
                completion["input"] = false;
                InputFilePath.Text = "File does not exist.";
            }
            CompletionChanged();
        }

        private void OutputFilePicker_FileOk(object sender, CancelEventArgs e)
        {
            OutputFilePath.Text = OutputFilePicker.FileName;
            completion["output"] = true;
            
            CompletionChanged();
        }

        private void InputFilePath_MouseDown(object sender, MouseEventArgs e)
        {
            InputFilePath.DoDragDrop(this, DragDropEffects.Link);
        }

        private void EncryptRadial_CheckedChanged(object sender, EventArgs e)
        {
            completion["type"] = true;
            CompletionChanged();
        }

        private void DecryptRadial_CheckedChanged(object sender, EventArgs e)
        {
            completion["type"] = true;
            CompletionChanged();
        }

        private void CompletionChanged()
        {
            if (completion["password"]
             && completion["type"]
             && completion["input"]
             && completion["output"])
            {
                StartStopButton.Enabled = true;
            }
            else if (StartStopButton.Text == "Start")
                StartStopButton.Enabled = false;
        }

        private void updateTime(int ms, int bytes)
        {
            decimal msPmb;
            try
            {
                msPmb = (decimal)(ms * (1048576 / bytes));
            }
            catch(DivideByZeroException)
            {
                msPmb = 0;
            }
            int sPmb = (int)Math.Floor(msPmb);
            CurSpeedDataDisplay.Text = sPmb.ToString() + " MB/S";

            if(sPmb > 1024)
            {
                ReadSpeed.Value = 1024;
            }
            else if(sPmb < 0)
            {
                //throw new ArgumentOutOfRangeException();
                ReadSpeed.Value = 512;
            }
            else
            {
                ReadSpeed.Value = sPmb;
            }
        }

        private void AES256helper(string inputFilename, string outputFilename, bool isOperationTypeEncryption, byte[] passwordHash)
        {
            byte[] key = new byte[32]; // 256 bits key
            byte[] iv = new byte[16];  // 128 bits IV (AES block size)

            statusLabel.Text = "BUSY.";

            Array.Copy(passwordHash, key, key.Length); // Use the first 32 bytes for the key

            using (Rijndael rijndael = Rijndael.Create())
            {
                rijndael.KeySize = 256;
                rijndael.BlockSize = 128;
                rijndael.Key = key;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;

                try
                {
                    if (File.Exists(outputFilename))
                    {
                        statusLabel.Text = "COMFIRMATION.";
                        DialogResult result = MessageBox.Show($"The file at ({outputFilename}), already exists. Do you want to overwrite it?", "Overwrite File?",
                                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.No || result == DialogResult.Cancel)
                            throw new OperationCanceledException();
                        statusLabel.Text = "BUSY.";
                    }

                    if (isOperationTypeEncryption)
                    {
                        // Manually generate a random IV using Random
                        {
                            Random random = new Random();
                            random.NextBytes(iv);
                        }
                        rijndael.IV = iv;

                        // Encrypt the file
                        using (FileStream fsOutput = new FileStream(outputFilename, FileMode.Create))
                        {
                            // Write the IV at the beginning of the file
                            fsOutput.Write(iv, 0, iv.Length);

                            if (canceled) throw new OperationCanceledException();

                            using (CryptoStream cs = new CryptoStream(fsOutput, rijndael.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                using (FileStream fsInput = new FileStream(inputFilename, FileMode.Open))
                                {
                                    byte[] buffer = new byte[1048576];
                                    int bytesRead;
                                    Stopwatch stopwatch = Stopwatch.StartNew();

                                    while ((bytesRead = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        stopwatch.Start();
                                        // Write encrypted data
                                        cs.Write(buffer, 0, bytesRead);

                                        // Measure performance
                                        stopwatch.Stop();
                                        int elapsedMS = (int)stopwatch.Elapsed.TotalMilliseconds;
                                        updateTime(elapsedMS, bytesRead); // Replace with actual performance reporting
                                        stopwatch.Reset();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Decrypt the file
                        using (FileStream fsInput = new FileStream(inputFilename, FileMode.Open))
                        {
                            // Read the IV from the beginning of the file
                            fsInput.Read(iv, 0, iv.Length);
                            rijndael.IV = iv;

                            if (canceled) throw new OperationCanceledException();

                            using (CryptoStream cs = new CryptoStream(fsInput, rijndael.CreateDecryptor(), CryptoStreamMode.Read))
                            {
                                using (FileStream fsOutput = new FileStream(outputFilename, FileMode.Create))
                                {
                                    byte[] buffer = new byte[1048576];
                                    int bytesRead;
                                    Stopwatch stopwatch = Stopwatch.StartNew();

                                    while ((bytesRead = cs.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        stopwatch.Start();

                                        // Write decrypted data
                                        fsOutput.Write(buffer, 0, bytesRead);

                                        // Measure performance
                                        stopwatch.Stop();
                                        int elapsedMS = (int)stopwatch.Elapsed.TotalMilliseconds;
                                        updateTime(elapsedMS, bytesRead); // Replace with actual performance reporting
                                        stopwatch.Reset();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    statusLabel.Text = "CANCELED.";
                    MessageBox.Show("Operation Canceled.", "Operation Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (CryptographicException e)
                {
                    statusLabel.Text = "ERROR.";
                    StartStopButton.Enabled = false;
                    StartStopButton.Text = "ERROR";
                    MessageBox.Show($"{e.Message} \n\nCauses include\nThe password is wrong.\n>The input file is corrupted.\n>(Rarely) This program has a bug.", "AES256helper Error (Cryptographic)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    StartStopButton.Enabled = true;
                }
                catch (Exception e)
                {
                    statusLabel.Text = "ERROR.";
                    StartStopButton.Enabled = false;
                    StartStopButton.Text = "ERROR";
                    MessageBox.Show(e.Message, "AES256helper Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    StartStopButton.Enabled = true;
                }
                finally
                {
                    StartStopButton.Text = "Start";
                    hasOperationStarted = false; // done.
                    QuitButton.Enabled = true;
                    CompletionChanged();
                    statusLabel.Text = "READY.";
                }
            }
        }
    }
}
