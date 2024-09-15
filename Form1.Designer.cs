using System.Windows.Forms;

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
            this.EncryptRadial = new System.Windows.Forms.RadioButton();
            this.DecryptRadial = new System.Windows.Forms.RadioButton();
            this.InputFilePath = new System.Windows.Forms.TextBox();
            this.InputFilePickButton = new System.Windows.Forms.Button();
            this.InputFilePicker = new System.Windows.Forms.OpenFileDialog();
            this.OutputFilePicker = new System.Windows.Forms.SaveFileDialog();
            this.OutputFilePath = new System.Windows.Forms.TextBox();
            this.OutputFilePickButton = new System.Windows.Forms.Button();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PMultipleFileProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.PCurrentFileProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.PSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.EncryptionMethodTextBox = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.OutputFolderPath = new System.Windows.Forms.TextBox();
            this.RemoveTopLevelExtension = new System.Windows.Forms.CheckBox();
            this.RemoveFilesButton = new System.Windows.Forms.Button();
            this.AddMulFiles = new System.Windows.Forms.Button();
            this.MulInputFileListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordCollection = new System.Windows.Forms.GroupBox();
            this.EncrpytionMethodCollection = new System.Windows.Forms.GroupBox();
            this.InputOutputOptions = new System.Windows.Forms.TabControl();
            this.OneFile = new System.Windows.Forms.TabPage();
            this.OutputBoxCollection = new System.Windows.Forms.GroupBox();
            this.InputBoxCollection = new System.Windows.Forms.GroupBox();
            this.MultipleFiles = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputExtensionLabel = new System.Windows.Forms.Label();
            this.ExtensionBox = new System.Windows.Forms.TextBox();
            this.FolderSelectionButton = new System.Windows.Forms.Button();
            this.InputLabelMul = new System.Windows.Forms.Label();
            this.IOCLabel = new System.Windows.Forms.Label();
            this.FolderSelection = new System.Windows.Forms.FolderBrowserDialog();
            this.MulInputFiles = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PasswordCollection.SuspendLayout();
            this.EncrpytionMethodCollection.SuspendLayout();
            this.InputOutputOptions.SuspendLayout();
            this.OneFile.SuspendLayout();
            this.OutputBoxCollection.SuspendLayout();
            this.InputBoxCollection.SuspendLayout();
            this.MultipleFiles.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptRadial
            // 
            this.EncryptRadial.AutoSize = true;
            this.helpProvider.SetHelpString(this.EncryptRadial, "These two selection button tells the program what operation you want to do.");
            this.EncryptRadial.Location = new System.Drawing.Point(6, 7);
            this.EncryptRadial.Name = "EncryptRadial";
            this.helpProvider.SetShowHelp(this.EncryptRadial, true);
            this.EncryptRadial.Size = new System.Drawing.Size(61, 17);
            this.EncryptRadial.TabIndex = 0;
            this.EncryptRadial.Text = "Encrypt";
            this.EncryptRadial.UseVisualStyleBackColor = true;
            this.EncryptRadial.CheckedChanged += new System.EventHandler(this.EncryptRadial_CheckedChanged);
            // 
            // DecryptRadial
            // 
            this.DecryptRadial.AutoSize = true;
            this.helpProvider.SetHelpString(this.DecryptRadial, "These two selection button tells the program what operation you want to do.");
            this.DecryptRadial.Location = new System.Drawing.Point(73, 7);
            this.DecryptRadial.Name = "DecryptRadial";
            this.helpProvider.SetShowHelp(this.DecryptRadial, true);
            this.DecryptRadial.Size = new System.Drawing.Size(62, 17);
            this.DecryptRadial.TabIndex = 1;
            this.DecryptRadial.Text = "Decrypt";
            this.DecryptRadial.UseVisualStyleBackColor = true;
            this.DecryptRadial.CheckedChanged += new System.EventHandler(this.DecryptRadial_CheckedChanged);
            // 
            // InputFilePath
            // 
            this.InputFilePath.AllowDrop = true;
            this.helpProvider.SetHelpString(this.InputFilePath, "This text box cannot be edited. It is read only. This text box shows the path of " +
        "the currently selected input path.\n\nYou can drag an item into this text box to s" +
        "elect the path.");
            this.InputFilePath.Location = new System.Drawing.Point(6, 16);
            this.InputFilePath.Name = "InputFilePath";
            this.InputFilePath.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.InputFilePath, true);
            this.InputFilePath.Size = new System.Drawing.Size(266, 20);
            this.InputFilePath.TabIndex = 0;
            this.InputFilePath.Text = "No file selected";
            this.InputFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFilePath_DragDrop);
            this.InputFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputFilePath_DragEnter);
            this.InputFilePath.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputFilePath_MouseDown);
            // 
            // InputFilePickButton
            // 
            this.helpProvider.SetHelpString(this.InputFilePickButton, "This button is used to pick the input file.\n\nClick it to activate it.");
            this.InputFilePickButton.Location = new System.Drawing.Point(278, 16);
            this.InputFilePickButton.Name = "InputFilePickButton";
            this.helpProvider.SetShowHelp(this.InputFilePickButton, true);
            this.InputFilePickButton.Size = new System.Drawing.Size(68, 20);
            this.InputFilePickButton.TabIndex = 1;
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
            this.OutputFilePicker.OverwritePrompt = false;
            this.OutputFilePicker.Title = "Pick a location to save the processed result.";
            this.OutputFilePicker.FileOk += new System.ComponentModel.CancelEventHandler(this.OutputFilePicker_FileOk);
            // 
            // OutputFilePath
            // 
            this.helpProvider.SetHelpString(this.OutputFilePath, "This text box cannot be edited. It is read only. This text box shows the path of " +
        "the currently selected output path.");
            this.OutputFilePath.Location = new System.Drawing.Point(6, 16);
            this.OutputFilePath.Name = "OutputFilePath";
            this.OutputFilePath.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.OutputFilePath, true);
            this.OutputFilePath.Size = new System.Drawing.Size(266, 20);
            this.OutputFilePath.TabIndex = 0;
            this.OutputFilePath.Text = "No file selected.";
            // 
            // OutputFilePickButton
            // 
            this.helpProvider.SetHelpString(this.OutputFilePickButton, "This button is used to pick the output file.\n\nClick it to activate it.");
            this.OutputFilePickButton.Location = new System.Drawing.Point(278, 16);
            this.OutputFilePickButton.Name = "OutputFilePickButton";
            this.helpProvider.SetShowHelp(this.OutputFilePickButton, true);
            this.OutputFilePickButton.Size = new System.Drawing.Size(68, 20);
            this.OutputFilePickButton.TabIndex = 4;
            this.OutputFilePickButton.Text = "Pick";
            this.OutputFilePickButton.UseVisualStyleBackColor = true;
            this.OutputFilePickButton.Click += new System.EventHandler(this.OutputFilePickButton_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Enabled = false;
            this.helpProvider.SetHelpString(this.StartStopButton, "This start/stop button does what it says it will do. It will start and stop the f" +
        "ile operations.");
            this.StartStopButton.Location = new System.Drawing.Point(261, 3);
            this.StartStopButton.Name = "StartStopButton";
            this.helpProvider.SetShowHelp(this.StartStopButton, true);
            this.StartStopButton.Size = new System.Drawing.Size(57, 25);
            this.StartStopButton.TabIndex = 2;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.helpProvider.SetHelpString(this.QuitButton, "The exit button closes this program completely.");
            this.QuitButton.Location = new System.Drawing.Point(324, 3);
            this.QuitButton.Name = "QuitButton";
            this.helpProvider.SetShowHelp(this.QuitButton, true);
            this.QuitButton.Size = new System.Drawing.Size(57, 25);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Exit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // StatusStrip
            // 
            this.helpProvider.SetHelpString(this.StatusStrip, "This strip at the buttom displays the status of the current operation.");
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.PMultipleFileProgressBar,
            this.PCurrentFileProgress,
            this.PSpeedLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 239);
            this.StatusStrip.Name = "StatusStrip";
            this.helpProvider.SetShowHelp(this.StatusStrip, true);
            this.StatusStrip.Size = new System.Drawing.Size(384, 22);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(46, 17);
            this.statusLabel.Text = "READY.";
            // 
            // PMultipleFileProgressBar
            // 
            this.PMultipleFileProgressBar.MarqueeAnimationSpeed = 50;
            this.PMultipleFileProgressBar.Name = "PMultipleFileProgressBar";
            this.PMultipleFileProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // PCurrentFileProgress
            // 
            this.PCurrentFileProgress.Name = "PCurrentFileProgress";
            this.PCurrentFileProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // PSpeedLabel
            // 
            this.PSpeedLabel.Name = "PSpeedLabel";
            this.PSpeedLabel.Size = new System.Drawing.Size(34, 17);
            this.PSpeedLabel.Text = "0 B/S";
            // 
            // EncryptionMethodTextBox
            // 
            this.EncryptionMethodTextBox.Enabled = false;
            this.helpProvider.SetHelpString(this.EncryptionMethodTextBox, "This box displays which algorithm you are using right now.");
            this.EncryptionMethodTextBox.Location = new System.Drawing.Point(6, 16);
            this.EncryptionMethodTextBox.Name = "EncryptionMethodTextBox";
            this.helpProvider.SetShowHelp(this.EncryptionMethodTextBox, true);
            this.EncryptionMethodTextBox.Size = new System.Drawing.Size(103, 20);
            this.EncryptionMethodTextBox.TabIndex = 0;
            this.EncryptionMethodTextBox.Text = "aes256";
            // 
            // PasswordField
            // 
            this.helpProvider.SetHelpString(this.PasswordField, "This text box is the key to this file. The password should be the same password t" +
        "hat you used to encrypt it, otherwise the output will result in garbage.");
            this.PasswordField.Location = new System.Drawing.Point(6, 16);
            this.PasswordField.MaxLength = 256;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.helpProvider.SetShowHelp(this.PasswordField, true);
            this.PasswordField.Size = new System.Drawing.Size(233, 20);
            this.PasswordField.TabIndex = 0;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // OutputFolderPath
            // 
            this.helpProvider.SetHelpString(this.OutputFolderPath, "This text box displays the output directory. Click the \"Select Folder\" button to " +
        "choose the output folder.");
            this.OutputFolderPath.Location = new System.Drawing.Point(255, 44);
            this.OutputFolderPath.Name = "OutputFolderPath";
            this.OutputFolderPath.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.OutputFolderPath, true);
            this.OutputFolderPath.Size = new System.Drawing.Size(109, 20);
            this.OutputFolderPath.TabIndex = 4;
            this.OutputFolderPath.Text = "Please select a folder.";
            // 
            // RemoveTopLevelExtension
            // 
            this.RemoveTopLevelExtension.AutoSize = true;
            this.RemoveTopLevelExtension.Checked = true;
            this.RemoveTopLevelExtension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider.SetHelpString(this.RemoveTopLevelExtension, "Removes the extension of the current file name, and renames it such.");
            this.RemoveTopLevelExtension.Location = new System.Drawing.Point(314, 93);
            this.RemoveTopLevelExtension.Name = "RemoveTopLevelExtension";
            this.helpProvider.SetShowHelp(this.RemoveTopLevelExtension, true);
            this.RemoveTopLevelExtension.Size = new System.Drawing.Size(45, 17);
            this.RemoveTopLevelExtension.TabIndex = 6;
            this.RemoveTopLevelExtension.Text = "Top";
            this.RemoveTopLevelExtension.UseVisualStyleBackColor = true;
            this.RemoveTopLevelExtension.CheckedChanged += new System.EventHandler(this.RemoveTopLevelExtension_CheckedChanged);
            // 
            // RemoveFilesButton
            // 
            this.RemoveFilesButton.Enabled = false;
            this.helpProvider.SetHelpString(this.RemoveFilesButton, "This button removes a file from the selection.");
            this.RemoveFilesButton.Location = new System.Drawing.Point(131, 89);
            this.RemoveFilesButton.Name = "RemoveFilesButton";
            this.helpProvider.SetShowHelp(this.RemoveFilesButton, true);
            this.RemoveFilesButton.Size = new System.Drawing.Size(122, 23);
            this.RemoveFilesButton.TabIndex = 2;
            this.RemoveFilesButton.Text = "Remove File(s)";
            this.RemoveFilesButton.UseVisualStyleBackColor = true;
            this.RemoveFilesButton.Click += new System.EventHandler(this.RemoveFilesButton_Click);
            // 
            // AddMulFiles
            // 
            this.helpProvider.SetHelpString(this.AddMulFiles, "This button adds a file (or more) to the input files selction.");
            this.AddMulFiles.Location = new System.Drawing.Point(3, 89);
            this.AddMulFiles.Name = "AddMulFiles";
            this.helpProvider.SetShowHelp(this.AddMulFiles, true);
            this.AddMulFiles.Size = new System.Drawing.Size(122, 23);
            this.AddMulFiles.TabIndex = 1;
            this.AddMulFiles.Text = "Add File(s)";
            this.AddMulFiles.UseVisualStyleBackColor = true;
            this.AddMulFiles.Click += new System.EventHandler(this.AddMulFiles_Click);
            // 
            // MulInputFileListBox
            // 
            this.MulInputFileListBox.AllowDrop = true;
            this.MulInputFileListBox.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.MulInputFileListBox, "This box shows which files you\'ve added to the operation. Click the add button to" +
        " add a file to the input list, and use the remove button to remove a file from t" +
        "he selection.");
            this.MulInputFileListBox.Location = new System.Drawing.Point(3, 18);
            this.MulInputFileListBox.Name = "MulInputFileListBox";
            this.MulInputFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.helpProvider.SetShowHelp(this.MulInputFileListBox, true);
            this.MulInputFileListBox.Size = new System.Drawing.Size(250, 69);
            this.MulInputFileListBox.TabIndex = 0;
            this.MulInputFileListBox.SelectedIndexChanged += new System.EventHandler(this.MulInputFileListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Controls.Add(this.StartStopButton);
            this.panel1.Controls.Add(this.DecryptRadial);
            this.panel1.Controls.Add(this.EncryptRadial);
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 30);
            this.panel1.TabIndex = 4;
            // 
            // PasswordCollection
            // 
            this.PasswordCollection.Controls.Add(this.PasswordField);
            this.PasswordCollection.Location = new System.Drawing.Point(8, 165);
            this.PasswordCollection.Name = "PasswordCollection";
            this.PasswordCollection.Size = new System.Drawing.Size(245, 42);
            this.PasswordCollection.TabIndex = 2;
            this.PasswordCollection.TabStop = false;
            this.PasswordCollection.Text = "Password";
            // 
            // EncrpytionMethodCollection
            // 
            this.EncrpytionMethodCollection.Controls.Add(this.EncryptionMethodTextBox);
            this.EncrpytionMethodCollection.Location = new System.Drawing.Point(259, 165);
            this.EncrpytionMethodCollection.Name = "EncrpytionMethodCollection";
            this.EncrpytionMethodCollection.Size = new System.Drawing.Size(115, 42);
            this.EncrpytionMethodCollection.TabIndex = 3;
            this.EncrpytionMethodCollection.TabStop = false;
            this.EncrpytionMethodCollection.Text = "Encrpytion Method";
            // 
            // InputOutputOptions
            // 
            this.InputOutputOptions.Controls.Add(this.OneFile);
            this.InputOutputOptions.Controls.Add(this.MultipleFiles);
            this.InputOutputOptions.Location = new System.Drawing.Point(6, 23);
            this.InputOutputOptions.Name = "InputOutputOptions";
            this.InputOutputOptions.SelectedIndex = 0;
            this.InputOutputOptions.Size = new System.Drawing.Size(375, 142);
            this.InputOutputOptions.TabIndex = 1;
            this.InputOutputOptions.Selected += new System.Windows.Forms.TabControlEventHandler(this.InputOutputOptions_Selected);
            // 
            // OneFile
            // 
            this.OneFile.Controls.Add(this.OutputBoxCollection);
            this.OneFile.Controls.Add(this.InputBoxCollection);
            this.OneFile.Location = new System.Drawing.Point(4, 22);
            this.OneFile.Name = "OneFile";
            this.OneFile.Padding = new System.Windows.Forms.Padding(3);
            this.OneFile.Size = new System.Drawing.Size(367, 116);
            this.OneFile.TabIndex = 0;
            this.OneFile.Text = "One File";
            this.OneFile.UseVisualStyleBackColor = true;
            // 
            // OutputBoxCollection
            // 
            this.OutputBoxCollection.Controls.Add(this.OutputFilePickButton);
            this.OutputBoxCollection.Controls.Add(this.OutputFilePath);
            this.OutputBoxCollection.Location = new System.Drawing.Point(6, 57);
            this.OutputBoxCollection.Name = "OutputBoxCollection";
            this.OutputBoxCollection.Size = new System.Drawing.Size(358, 45);
            this.OutputBoxCollection.TabIndex = 1;
            this.OutputBoxCollection.TabStop = false;
            this.OutputBoxCollection.Text = "Output File";
            // 
            // InputBoxCollection
            // 
            this.InputBoxCollection.Controls.Add(this.InputFilePath);
            this.InputBoxCollection.Controls.Add(this.InputFilePickButton);
            this.InputBoxCollection.Location = new System.Drawing.Point(6, 6);
            this.InputBoxCollection.Name = "InputBoxCollection";
            this.InputBoxCollection.Size = new System.Drawing.Size(356, 45);
            this.InputBoxCollection.TabIndex = 0;
            this.InputBoxCollection.TabStop = false;
            this.InputBoxCollection.Text = "Input File";
            // 
            // MultipleFiles
            // 
            this.MultipleFiles.Controls.Add(this.RemoveFilesButton);
            this.MultipleFiles.Controls.Add(this.AddMulFiles);
            this.MultipleFiles.Controls.Add(this.label1);
            this.MultipleFiles.Controls.Add(this.RemoveTopLevelExtension);
            this.MultipleFiles.Controls.Add(this.OutputExtensionLabel);
            this.MultipleFiles.Controls.Add(this.ExtensionBox);
            this.MultipleFiles.Controls.Add(this.FolderSelectionButton);
            this.MultipleFiles.Controls.Add(this.OutputFolderPath);
            this.MultipleFiles.Controls.Add(this.InputLabelMul);
            this.MultipleFiles.Controls.Add(this.MulInputFileListBox);
            this.MultipleFiles.Location = new System.Drawing.Point(4, 22);
            this.MultipleFiles.Name = "MultipleFiles";
            this.MultipleFiles.Padding = new System.Windows.Forms.Padding(3);
            this.MultipleFiles.Size = new System.Drawing.Size(367, 116);
            this.MultipleFiles.TabIndex = 1;
            this.MultipleFiles.Text = "Multiple Files";
            this.MultipleFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output Files";
            // 
            // OutputExtensionLabel
            // 
            this.OutputExtensionLabel.AutoSize = true;
            this.OutputExtensionLabel.Location = new System.Drawing.Point(259, 75);
            this.OutputExtensionLabel.Name = "OutputExtensionLabel";
            this.OutputExtensionLabel.Size = new System.Drawing.Size(92, 13);
            this.OutputExtensionLabel.TabIndex = 5;
            this.OutputExtensionLabel.Text = "Extension Options";
            // 
            // ExtensionBox
            // 
            this.ExtensionBox.Location = new System.Drawing.Point(255, 91);
            this.ExtensionBox.Name = "ExtensionBox";
            this.ExtensionBox.Size = new System.Drawing.Size(57, 20);
            this.ExtensionBox.TabIndex = 5;
            this.ExtensionBox.Text = "aes";
            // 
            // FolderSelectionButton
            // 
            this.FolderSelectionButton.Location = new System.Drawing.Point(255, 18);
            this.FolderSelectionButton.Name = "FolderSelectionButton";
            this.FolderSelectionButton.Size = new System.Drawing.Size(109, 23);
            this.FolderSelectionButton.TabIndex = 3;
            this.FolderSelectionButton.Text = "Select Folder";
            this.FolderSelectionButton.UseVisualStyleBackColor = true;
            this.FolderSelectionButton.Click += new System.EventHandler(this.FolderSelectionButton_Click);
            // 
            // InputLabelMul
            // 
            this.InputLabelMul.AutoSize = true;
            this.InputLabelMul.Location = new System.Drawing.Point(3, 3);
            this.InputLabelMul.Name = "InputLabelMul";
            this.InputLabelMul.Size = new System.Drawing.Size(55, 13);
            this.InputLabelMul.TabIndex = 1;
            this.InputLabelMul.Text = "Input Files";
            // 
            // IOCLabel
            // 
            this.IOCLabel.AutoSize = true;
            this.IOCLabel.Location = new System.Drawing.Point(244, 27);
            this.IOCLabel.Name = "IOCLabel";
            this.IOCLabel.Size = new System.Drawing.Size(128, 13);
            this.IOCLabel.TabIndex = 26;
            this.IOCLabel.Text = "Input and Output Controls";
            // 
            // FolderSelection
            // 
            this.FolderSelection.Description = "Choose an output folder to write data into.";
            // 
            // MulInputFiles
            // 
            this.MulInputFiles.DefaultExt = "*.aes|*.*";
            this.MulInputFiles.Filter = "AES Files|*.aes|All Files|*.*";
            this.MulInputFiles.Multiselect = true;
            this.MulInputFiles.Title = "Add input file(s)";
            this.MulInputFiles.FileOk += new System.ComponentModel.CancelEventHandler(this.MulInputFiles_FileOk);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(384, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // operationStripMenuItem
            // 
            this.operationStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.operationStripMenuItem.Name = "operationStripMenuItem";
            this.operationStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationStripMenuItem.Text = "Operation";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.QuitButton;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.IOCLabel);
            this.Controls.Add(this.InputOutputOptions);
            this.Controls.Add(this.EncrpytionMethodCollection);
            this.Controls.Add(this.PasswordCollection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 1024);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "MainWindow";
            this.Text = "Encryption Applet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PasswordCollection.ResumeLayout(false);
            this.PasswordCollection.PerformLayout();
            this.EncrpytionMethodCollection.ResumeLayout(false);
            this.EncrpytionMethodCollection.PerformLayout();
            this.InputOutputOptions.ResumeLayout(false);
            this.OneFile.ResumeLayout(false);
            this.OutputBoxCollection.ResumeLayout(false);
            this.OutputBoxCollection.PerformLayout();
            this.InputBoxCollection.ResumeLayout(false);
            this.InputBoxCollection.PerformLayout();
            this.MultipleFiles.ResumeLayout(false);
            this.MultipleFiles.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton EncryptRadial;
        private System.Windows.Forms.RadioButton DecryptRadial;
        private System.Windows.Forms.TextBox InputFilePath;
        private System.Windows.Forms.Button InputFilePickButton;
        private System.Windows.Forms.OpenFileDialog InputFilePicker;
        private System.Windows.Forms.SaveFileDialog OutputFilePicker;
        private System.Windows.Forms.TextBox OutputFilePath;
        private System.Windows.Forms.Button OutputFilePickButton;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EncryptionMethodTextBox;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.GroupBox PasswordCollection;
        private System.Windows.Forms.GroupBox EncrpytionMethodCollection;
        private System.Windows.Forms.TabControl InputOutputOptions;
        private System.Windows.Forms.TabPage OneFile;
        private System.Windows.Forms.TabPage MultipleFiles;
        private System.Windows.Forms.GroupBox InputBoxCollection;
        private System.Windows.Forms.GroupBox OutputBoxCollection;
        private System.Windows.Forms.Label IOCLabel;
        private System.Windows.Forms.Label InputLabelMul;
        private System.Windows.Forms.ListBox MulInputFileListBox;
        private System.Windows.Forms.ToolStripProgressBar PMultipleFileProgressBar;
        private System.Windows.Forms.Label OutputExtensionLabel;
        private System.Windows.Forms.TextBox ExtensionBox;
        private System.Windows.Forms.Button FolderSelectionButton;
        private System.Windows.Forms.TextBox OutputFolderPath;
        private System.Windows.Forms.CheckBox RemoveTopLevelExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog FolderSelection;
        private System.Windows.Forms.Button AddMulFiles;
        private System.Windows.Forms.OpenFileDialog MulInputFiles;
        private System.Windows.Forms.Button RemoveFilesButton;
        private ToolStripProgressBar PCurrentFileProgress;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem operationStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripStatusLabel PSpeedLabel;
    }
}

