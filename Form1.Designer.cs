namespace EncryptionGUIwWindowsForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.EncryptionMethodLabel = new System.Windows.Forms.Label();
            this.EncryptRadial = new System.Windows.Forms.RadioButton();
            this.DecryptRadial = new System.Windows.Forms.RadioButton();
            this.EncryptionMethodTextBox = new System.Windows.Forms.TextBox();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.InputFilePath = new System.Windows.Forms.TextBox();
            this.InputFilePickButton = new System.Windows.Forms.Button();
            this.InputFilePicker = new System.Windows.Forms.OpenFileDialog();
            this.OutputFilePicker = new System.Windows.Forms.SaveFileDialog();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.OutputFilePath = new System.Windows.Forms.TextBox();
            this.OutputFilePickButton = new System.Windows.Forms.Button();
            this.ReadSpeed = new System.Windows.Forms.ProgressBar();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SpeedIndicatorLeft = new System.Windows.Forms.Label();
            this.MinSpeedLabel = new System.Windows.Forms.Label();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.CurrentSpeedLabel = new System.Windows.Forms.Label();
            this.CurSpeedDataDisplay = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 9);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(74, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password Key";
            // 
            // PasswordField
            // 
            this.helpProvider.SetHelpString(this.PasswordField, "This text box is the key to this file. The password should be the same password t" +
        "hat you used to encrypt it, otherwise the output will result in garbage.");
            this.PasswordField.Location = new System.Drawing.Point(12, 25);
            this.PasswordField.MaxLength = 256;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.helpProvider.SetShowHelp(this.PasswordField, true);
            this.PasswordField.Size = new System.Drawing.Size(233, 20);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // EncryptionMethodLabel
            // 
            this.EncryptionMethodLabel.AutoSize = true;
            this.EncryptionMethodLabel.Location = new System.Drawing.Point(248, 8);
            this.EncryptionMethodLabel.Name = "EncryptionMethodLabel";
            this.EncryptionMethodLabel.Size = new System.Drawing.Size(96, 13);
            this.EncryptionMethodLabel.TabIndex = 3;
            this.EncryptionMethodLabel.Text = "Encryption Method";
            // 
            // EncryptRadial
            // 
            this.EncryptRadial.AutoSize = true;
            this.helpProvider.SetHelpString(this.EncryptRadial, "These two selection button tells the program what operation you want to do.");
            this.EncryptRadial.Location = new System.Drawing.Point(251, 51);
            this.EncryptRadial.Name = "EncryptRadial";
            this.helpProvider.SetShowHelp(this.EncryptRadial, true);
            this.EncryptRadial.Size = new System.Drawing.Size(61, 17);
            this.EncryptRadial.TabIndex = 4;
            this.EncryptRadial.TabStop = true;
            this.EncryptRadial.Text = "Encrypt";
            this.EncryptRadial.UseVisualStyleBackColor = true;
            this.EncryptRadial.CheckedChanged += new System.EventHandler(this.EncryptRadial_CheckedChanged);
            // 
            // DecryptRadial
            // 
            this.DecryptRadial.AutoSize = true;
            this.helpProvider.SetHelpString(this.DecryptRadial, "These two selection button tells the program what operation you want to do.");
            this.DecryptRadial.Location = new System.Drawing.Point(251, 74);
            this.DecryptRadial.Name = "DecryptRadial";
            this.helpProvider.SetShowHelp(this.DecryptRadial, true);
            this.DecryptRadial.Size = new System.Drawing.Size(62, 17);
            this.DecryptRadial.TabIndex = 5;
            this.DecryptRadial.TabStop = true;
            this.DecryptRadial.Text = "Decrypt";
            this.DecryptRadial.UseVisualStyleBackColor = true;
            this.DecryptRadial.CheckedChanged += new System.EventHandler(this.DecryptRadial_CheckedChanged);
            // 
            // EncryptionMethodTextBox
            // 
            this.EncryptionMethodTextBox.Enabled = false;
            this.helpProvider.SetHelpString(this.EncryptionMethodTextBox, "This box displays which algorithm you are using right now.");
            this.EncryptionMethodTextBox.Location = new System.Drawing.Point(251, 25);
            this.EncryptionMethodTextBox.Name = "EncryptionMethodTextBox";
            this.helpProvider.SetShowHelp(this.EncryptionMethodTextBox, true);
            this.EncryptionMethodTextBox.Size = new System.Drawing.Size(121, 20);
            this.EncryptionMethodTextBox.TabIndex = 6;
            this.EncryptionMethodTextBox.Text = "aes256";
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Location = new System.Drawing.Point(12, 48);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(50, 13);
            this.InputFileLabel.TabIndex = 7;
            this.InputFileLabel.Text = "Input File";
            // 
            // InputFilePath
            // 
            this.InputFilePath.AllowDrop = true;
            this.helpProvider.SetHelpString(this.InputFilePath, "This text box cannot be edited. It is read only. This text box shows the path of " +
        "the currently selected input path.\n\nYou can drag an item into this text box to s" +
        "elect the path.");
            this.InputFilePath.Location = new System.Drawing.Point(12, 64);
            this.InputFilePath.Name = "InputFilePath";
            this.InputFilePath.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.InputFilePath, true);
            this.InputFilePath.Size = new System.Drawing.Size(159, 20);
            this.InputFilePath.TabIndex = 8;
            this.InputFilePath.Text = "No file selected";
            this.InputFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFilePath_DragDrop);
            this.InputFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputFilePath_DragEnter);
            this.InputFilePath.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputFilePath_MouseDown);
            // 
            // InputFilePickButton
            // 
            this.helpProvider.SetHelpString(this.InputFilePickButton, "This button is used to pick the input file.\n\nClick it to activate it.");
            this.InputFilePickButton.Location = new System.Drawing.Point(177, 64);
            this.InputFilePickButton.Name = "InputFilePickButton";
            this.helpProvider.SetShowHelp(this.InputFilePickButton, true);
            this.InputFilePickButton.Size = new System.Drawing.Size(68, 20);
            this.InputFilePickButton.TabIndex = 9;
            this.InputFilePickButton.Text = "Pick";
            this.InputFilePickButton.UseVisualStyleBackColor = true;
            this.InputFilePickButton.Click += new System.EventHandler(this.InputFilePickButton_Click);
            // 
            // InputFilePicker
            // 
            this.InputFilePicker.DefaultExt = "*.aes|*.*";
            this.InputFilePicker.Filter = "AES Files|*.aes|All Files|*.*";
            this.InputFilePicker.Title = "Open a file to process.";
            this.InputFilePicker.FileOk += new System.ComponentModel.CancelEventHandler(this.InputFilePicker_FileOk);
            // 
            // OutputFilePicker
            // 
            this.OutputFilePicker.DefaultExt = "*.aes|*.*";
            this.OutputFilePicker.Filter = "AES Files|*.aes|All Files|*.*";
            this.OutputFilePicker.Title = "Pick a location to save the processed result.";
            this.OutputFilePicker.FileOk += new System.ComponentModel.CancelEventHandler(this.OutputFilePicker_FileOk);
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Location = new System.Drawing.Point(12, 87);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(58, 13);
            this.OutputFileLabel.TabIndex = 10;
            this.OutputFileLabel.Text = "Output File";
            // 
            // OutputFilePath
            // 
            this.helpProvider.SetHelpString(this.OutputFilePath, "This text box cannot be edited. It is read only. This text box shows the path of " +
        "the currently selected output path.");
            this.OutputFilePath.Location = new System.Drawing.Point(12, 103);
            this.OutputFilePath.Name = "OutputFilePath";
            this.OutputFilePath.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.OutputFilePath, true);
            this.OutputFilePath.Size = new System.Drawing.Size(159, 20);
            this.OutputFilePath.TabIndex = 11;
            this.OutputFilePath.Text = "No file selected.";
            // 
            // OutputFilePickButton
            // 
            this.helpProvider.SetHelpString(this.OutputFilePickButton, "This button is used to pick the output file.\n\nClick it to activate it.");
            this.OutputFilePickButton.Location = new System.Drawing.Point(177, 103);
            this.OutputFilePickButton.Name = "OutputFilePickButton";
            this.helpProvider.SetShowHelp(this.OutputFilePickButton, true);
            this.OutputFilePickButton.Size = new System.Drawing.Size(68, 20);
            this.OutputFilePickButton.TabIndex = 12;
            this.OutputFilePickButton.Text = "Pick";
            this.OutputFilePickButton.UseVisualStyleBackColor = true;
            this.OutputFilePickButton.Click += new System.EventHandler(this.OutputFilePickButton_Click);
            // 
            // ReadSpeed
            // 
            this.ReadSpeed.Location = new System.Drawing.Point(12, 142);
            this.ReadSpeed.Name = "ReadSpeed";
            this.ReadSpeed.Size = new System.Drawing.Size(279, 31);
            this.ReadSpeed.TabIndex = 13;
            // 
            // StartStopButton
            // 
            this.StartStopButton.Enabled = false;
            this.helpProvider.SetHelpString(this.StartStopButton, "This start/stop button does what it says it will do. It will start and stop the f" +
        "ile operations.");
            this.StartStopButton.Location = new System.Drawing.Point(251, 98);
            this.StartStopButton.Name = "StartStopButton";
            this.helpProvider.SetShowHelp(this.StartStopButton, true);
            this.StartStopButton.Size = new System.Drawing.Size(57, 25);
            this.StartStopButton.TabIndex = 14;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // QuitButton
            // 
            this.helpProvider.SetHelpString(this.QuitButton, "The exit button closes this program completely.");
            this.QuitButton.Location = new System.Drawing.Point(315, 98);
            this.QuitButton.Name = "QuitButton";
            this.helpProvider.SetShowHelp(this.QuitButton, true);
            this.QuitButton.Size = new System.Drawing.Size(57, 25);
            this.QuitButton.TabIndex = 15;
            this.QuitButton.Text = "Exit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SpeedIndicatorLeft
            // 
            this.SpeedIndicatorLeft.AutoSize = true;
            this.SpeedIndicatorLeft.Location = new System.Drawing.Point(12, 126);
            this.SpeedIndicatorLeft.Name = "SpeedIndicatorLeft";
            this.SpeedIndicatorLeft.Size = new System.Drawing.Size(63, 13);
            this.SpeedIndicatorLeft.TabIndex = 16;
            this.SpeedIndicatorLeft.Text = "Speed (MB)";
            // 
            // MinSpeedLabel
            // 
            this.MinSpeedLabel.AutoSize = true;
            this.MinSpeedLabel.Location = new System.Drawing.Point(12, 176);
            this.MinSpeedLabel.Name = "MinSpeedLabel";
            this.MinSpeedLabel.Size = new System.Drawing.Size(44, 13);
            this.MinSpeedLabel.TabIndex = 17;
            this.MinSpeedLabel.Text = "0 MB/S";
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Location = new System.Drawing.Point(229, 176);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(62, 13);
            this.MaxSpeedLabel.TabIndex = 18;
            this.MaxSpeedLabel.Text = "1024 MB/S";
            // 
            // CurrentSpeedLabel
            // 
            this.CurrentSpeedLabel.AutoSize = true;
            this.CurrentSpeedLabel.Location = new System.Drawing.Point(297, 137);
            this.CurrentSpeedLabel.Name = "CurrentSpeedLabel";
            this.CurrentSpeedLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentSpeedLabel.TabIndex = 19;
            this.CurrentSpeedLabel.Text = "Current Speed";
            // 
            // CurSpeedDataDisplay
            // 
            this.helpProvider.SetHelpString(this.CurSpeedDataDisplay, "This text box displays the current speed of the file operation.");
            this.CurSpeedDataDisplay.Location = new System.Drawing.Point(297, 153);
            this.CurSpeedDataDisplay.Name = "CurSpeedDataDisplay";
            this.CurSpeedDataDisplay.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.CurSpeedDataDisplay, true);
            this.CurSpeedDataDisplay.Size = new System.Drawing.Size(75, 20);
            this.CurSpeedDataDisplay.TabIndex = 20;
            this.CurSpeedDataDisplay.Text = "0 MB/S";
            // 
            // StatusStrip
            // 
            this.helpProvider.SetHelpString(this.StatusStrip, "This strip at the buttom displays the status of the current operation.");
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 239);
            this.StatusStrip.Name = "StatusStrip";
            this.helpProvider.SetShowHelp(this.StatusStrip, true);
            this.StatusStrip.Size = new System.Drawing.Size(384, 22);
            this.StatusStrip.TabIndex = 21;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(46, 17);
            this.statusLabel.Text = "READY.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.CurSpeedDataDisplay);
            this.Controls.Add(this.CurrentSpeedLabel);
            this.Controls.Add(this.MaxSpeedLabel);
            this.Controls.Add(this.MinSpeedLabel);
            this.Controls.Add(this.SpeedIndicatorLeft);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.ReadSpeed);
            this.Controls.Add(this.OutputFilePickButton);
            this.Controls.Add(this.OutputFilePath);
            this.Controls.Add(this.OutputFileLabel);
            this.Controls.Add(this.InputFilePickButton);
            this.Controls.Add(this.InputFilePath);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.EncryptionMethodTextBox);
            this.Controls.Add(this.DecryptRadial);
            this.Controls.Add(this.EncryptRadial);
            this.Controls.Add(this.EncryptionMethodLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 1024);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "MainWindow";
            this.Text = "Encryption Applet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label EncryptionMethodLabel;
        private System.Windows.Forms.RadioButton EncryptRadial;
        private System.Windows.Forms.RadioButton DecryptRadial;
        private System.Windows.Forms.TextBox EncryptionMethodTextBox;
        private System.Windows.Forms.Label InputFileLabel;
        private System.Windows.Forms.TextBox InputFilePath;
        private System.Windows.Forms.Button InputFilePickButton;
        private System.Windows.Forms.OpenFileDialog InputFilePicker;
        private System.Windows.Forms.SaveFileDialog OutputFilePicker;
        private System.Windows.Forms.Label OutputFileLabel;
        private System.Windows.Forms.TextBox OutputFilePath;
        private System.Windows.Forms.Button OutputFilePickButton;
        private System.Windows.Forms.ProgressBar ReadSpeed;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label SpeedIndicatorLeft;
        private System.Windows.Forms.Label MinSpeedLabel;
        private System.Windows.Forms.Label MaxSpeedLabel;
        private System.Windows.Forms.Label CurrentSpeedLabel;
        private System.Windows.Forms.TextBox CurSpeedDataDisplay;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}

