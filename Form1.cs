using System;
using System.CodeDom;
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
using System.Threading;
using ede;

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
            completion["oneInput"] = false;
            completion["oneOutput"] = false;
            completion["mulInput"] = false;
            completion["mulOutput"] = false;

            completion["isMulFiles"] = false;

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
                stopToolStripMenuItem.Enabled = false;

                canceled = true;
            }
            else
            {
                StartStopButton.Text = "Stop";
                stopToolStripMenuItem.Enabled = true;
                startToolStripMenuItem.Enabled = false;
                QuitButton.Enabled = false;

                if (InputOutputOptions.SelectedTab == OneFile)
                {
                    string[] inputFilename = new string[1];
                    string[] outputFilename = new string [1];
                    inputFilename[0] = InputFilePath.Text;
                    outputFilename[0] = OutputFilePath.Text;
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

                    //CancellationTokenSource source = new CancellationTokenSource();
                    //var cancellationToken = cancellationTokenSource.Token;

                    Thread thread = new Thread(() => ConsecutiveThreadManager(inputFilename, outputFilename, isOperationTypeEncryption, passwordHash));
                    thread.Name = "ConsecutiveWriteManager";
                    thread.Start();
                }
                else if(InputOutputOptions.SelectedTab == MultipleFiles)
                {
                    string[] inputFilenames = new string[MulInputFileListBox.Items.Count];
                    string[] outputFilenames = new string[inputFilenames.Length];
                    for (int i = 0; i < MulInputFileListBox.Items.Count; i++)
                        inputFilenames[i] = MulInputFileListBox.Items[i].ToString();
                    for(int i = 0; i < inputFilenames.Length; i++)
                    {
                        string[] splitPath = inputFilenames[i].Split('\\');
                        string[] filenameParts = splitPath[splitPath.Length - 1].Split('.');
                        string filename = "";
                        if(!RemoveTopLevelExtension.Checked)
                        {
                            filenameParts[filenameParts.Length - 1] = "";
                            for (int j = 0; j < filenameParts.Length - 3; j++)
                                filename += filenameParts[j] + ".";
                            filename += filenameParts[filenameParts.Length - 2];
                        }
                        else
                        {
                            filename += splitPath[splitPath.Length - 1];
                            filename += "." + ExtensionBox.Text;
                        }

                        outputFilenames[i] = OutputFolderPath.Text + "\\" + filename;
                    }

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
                    
                    Thread thread = new Thread(() => ConsecutiveThreadManager(inputFilenames, outputFilenames, isOperationTypeEncryption, passwordHash));
                    thread.Name = "ConsecutiveWriteManager";
                    thread.Start();
                }
            }
            hasOperationStarted = !hasOperationStarted;
        }

        private void ConsecutiveThreadManager(string[] inputFilename, string[] outputFilename, bool isOperationTypeEncryption, byte[] passwordHash)
        {
            PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.Minimum = 0));
            PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.Maximum = inputFilename.Length * 2));
            PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.Step = 1));
            PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.Value = 0));

            try
            { 
                for (int i = 0; i < Math.Min(inputFilename.Length, outputFilename.Length); i++)
                {
                    PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.PerformStep())); // half step
                    Tried:
                    try
                    {
                        AES256helper(inputFilename[i], outputFilename[i], isOperationTypeEncryption, passwordHash);
                    }
                    catch (OperationCanceledException)
                    {
                        throw new OperationCanceledException();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "Restart")
                        {
                            goto Tried; // restart the operation
                        }
                    }

                    PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.PerformStep())); // full step
                }
            }
            catch(OperationCanceledException)
            {
                statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "CANCELED."));
                MessageBox.Show("Operation Canceled.", "Operation Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                canceled = false;
            }

            // clean up
            PCurrentFileProgress.GetCurrentParent().Invoke((MethodInvoker)(() => PCurrentFileProgress.Value = 0));
            PMultipleFileProgressBar.GetCurrentParent().Invoke((MethodInvoker)(() => PMultipleFileProgressBar.Value = 0));
            StartStopButton.Invoke((MethodInvoker)(() => StartStopButton.Text = "Start"));
            hasOperationStarted = false; // done.
            QuitButton.Invoke((MethodInvoker)(() => QuitButton.Enabled = true));
            operationStripMenuItem.GetCurrentParent().Invoke((MethodInvoker)(() => startToolStripMenuItem.Enabled = true));
            StartStopButton.Invoke((MethodInvoker)(() => CompletionChanged()));
            statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "READY."));
            MessageBox.Show("Operation complete.", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            if (PasswordField.Text != "")
                completion["password"] = true;
            else
                completion["password"] = false;
            CompletionChanged();
        }

        private void InputFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                if (((string[])e.Data.GetData(DataFormats.FileDrop)).Length == 1)
                    e.Effect = DragDropEffects.Link;
            }
        }

        private void InputFilePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                InputFilePath.Text = files[0];

                completion["oneInput"] = true;
                CompletionChanged();
            }
        }

        private void InputFilePicker_FileOk(object sender, CancelEventArgs e)
        {
            InputFilePath.Text = InputFilePicker.FileName;
            completion["oneInput"] = true;
            if (!File.Exists(InputFilePicker.FileName))
            {
                completion["oneInput"] = false;
                InputFilePath.Text = "File does not exist.";
            }
            CompletionChanged();
        }

        private void OutputFilePicker_FileOk(object sender, CancelEventArgs e)
        {
            OutputFilePath.Text = OutputFilePicker.FileName;
            completion["oneOutput"] = true;

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
            if (completion["password"] && completion["type"] && 
                (completion["mulInput"] && completion["mulOutput"] && completion["isMulFiles"] || 
                completion["oneInput"] && completion["oneOutput"] && !completion["isMulFiles"]))
            {
                StartStopButton.Enabled = true;
                startToolStripMenuItem.Enabled = true;
            }
            else if (StartStopButton.Text == "Start")
            {
                StartStopButton.Enabled = false;
                startToolStripMenuItem.Enabled = false;
            }
        }

        private void AES256helper(string inputFilename, string outputFilename, bool isOperationTypeEncryption, byte[] passwordHash, bool isConsecutive = false)
        {
            byte[] key = new byte[32]; // 256 bits key
            byte[] iv = new byte[16];  // 128 bits IV (AES block size)

            // Update statusLabel on the UI thread
            statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "BUSY."));

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
                        statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "CONFIRMATION."));
                        DialogResult result = MessageBox.Show($"The file at ({outputFilename}), already exists. Do you want to overwrite it?", "Overwrite File?",
                                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.No || result == DialogResult.Cancel)
                            throw new OperationCanceledException();

                        statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "BUSY."));
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
                                    using (ProgressStream progressStream = new ProgressStream(fsInput))
                                    {
                                        progressStream.UpdateProgress += updateProgress;
                                        byte[] buffer = new byte[1048576];
                                        int bytesRead;

                                        while ((bytesRead = progressStream.Read(buffer, 0, buffer.Length)) > 0)
                                        {
                                            cs.Write(buffer, 0, bytesRead);
                                            if (canceled) throw new OperationCanceledException();
                                        }
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
                                    using (ProgressStream progressStream = new ProgressStream(cs))
                                    {
                                        progressStream.UpdateProgress += updateProgress;
                                        byte[] buffer = new byte[1048576];
                                        int bytesRead;

                                        while ((bytesRead = progressStream.Read(buffer, 0, buffer.Length)) > 0)
                                        {
                                            // Write decrypted data
                                            fsOutput.Write(buffer, 0, bytesRead);
                                            if (canceled) throw new OperationCanceledException();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    throw new OperationCanceledException();
                }
                catch (CryptographicException e)
                {
                    statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "ERROR."));
                    StartStopButton.Invoke((MethodInvoker)(() => {
                        StartStopButton.Enabled = false;
                        StartStopButton.Text = "ERROR";
                    }));
                    DialogResult result = MessageBox.Show($"{e.Message} \n\nCauses include\nThe password is wrong.\n>The input file is corrupted.\n>(Rarely) This program has a bug.", "AES256helper Error (Cryptographic)", 
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                    if (result == DialogResult.Abort)
                    {
                        throw new OperationCanceledException();
                    }
                    else if (result == DialogResult.Retry)
                    {
                        throw new Exception("Restart");
                    }
                    StartStopButton.Invoke((MethodInvoker)(() => {
                        StartStopButton.Enabled = true;
                        StartStopButton.Text = "Stop";
                    }));
                }
                catch (Exception e)
                {
                    statusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => statusLabel.Text = "ERROR."));
                    StartStopButton.Invoke((MethodInvoker)(() => {
                        StartStopButton.Enabled = false;
                        StartStopButton.Text = "ERROR";
                    }));
                    DialogResult result = MessageBox.Show(e.Message, "Error", 
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                    if (result == DialogResult.Abort)
                    {
                        throw new OperationCanceledException();
                    }
                    else if (result == DialogResult.Retry)
                    {
                        throw new Exception("Restart");
                    }
                    StartStopButton.Invoke((MethodInvoker)(() => {
                        StartStopButton.Enabled = true;
                        StartStopButton.Text = "Stop";
                    }));
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox = new AboutBox1();
            AboutBox.ShowDialog();
        }

        private void RemoveTopLevelExtension_CheckedChanged(object sender, EventArgs e)
        {
            if (RemoveTopLevelExtension.Checked == false)
                ExtensionBox.Enabled = false;
            else ExtensionBox.Enabled = true;
        }

        // Multiple Selection Section

        private void FolderSelectionButton_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderSelection.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputFolderPath.Text = FolderSelection.SelectedPath;
                completion["mulOutput"] = true;
            }
        }

        private void MulInputFiles_FileOk(object sender, CancelEventArgs e)
        {
            string[] added = MulInputFiles.FileNames;
            for(int i = 0; i < added.Length; i++)
            {
                if (!MulInputFileListBox.Items.Contains(added[i]))
                    MulInputFileListBox.Items.Add(added[i]);
            }

            completion["mulInput"] = true;
            CompletionChanged();
        }

        private void AddMulFiles_Click(object sender, EventArgs e)
        {
            MulInputFiles.ShowDialog();
        }

        private void MulInputFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MulInputFileListBox.SelectedItems.Count > 0) RemoveFilesButton.Enabled = true;
            else RemoveFilesButton.Enabled = false;
        }

        private void RemoveFilesButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < MulInputFileListBox.SelectedItems.Count; i++)
            {
                MulInputFileListBox.Items.Remove(MulInputFileListBox.SelectedItems[i]);
            }

            if(MulInputFileListBox.Items.Count == 0)
            {
                completion["mulInput"] = false;
                CompletionChanged();
            }
        }

        private void InputOutputOptions_Selected(object sender, TabControlEventArgs e)
        {
            if (InputOutputOptions.SelectedTab == MultipleFiles)
                completion["isMulFiles"] = true;
            else if (InputOutputOptions.SelectedTab == OneFile)
                completion["isMulFiles"] = false;
            else
                throw new NotImplementedException();
            CompletionChanged();
        }
        private void updateProgress(object sender, ProgressEventArgs e)
        {
            int progressPercent = (int)(e.Progress * 100.0f);
            PCurrentFileProgress.GetCurrentParent().Invoke((MethodInvoker)(() => PCurrentFileProgress.Value = progressPercent));
            PSpeedLabel.GetCurrentParent().Invoke((MethodInvoker)(() => PSpeedLabel.Text = e.BPS + " B/S"));
        }
    }
}
