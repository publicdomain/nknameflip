
namespace nkNameFlip
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.checkOnClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.loadFilesOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.totalToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.totalCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.doneToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.doneCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.intermediateFileTextBox = new System.Windows.Forms.TextBox();
        	this.intermediateFileLabel = new System.Windows.Forms.Label();
        	this.scriptProgramTextBox = new System.Windows.Forms.TextBox();
        	this.scriptProgramLabel = new System.Windows.Forms.Label();
        	this.rootDirectoryLabel = new System.Windows.Forms.Label();
        	this.rootDirectoryBrowseButton = new System.Windows.Forms.Button();
        	this.rootDirectoryTextBox = new System.Windows.Forms.TextBox();
        	this.loadFilesButton = new System.Windows.Forms.Button();
        	this.filesCheckedListBox = new System.Windows.Forms.CheckedListBox();
        	this.scriptProgramButton = new System.Windows.Forms.Button();
        	this.processButton = new System.Windows.Forms.Button();
        	this.intermediateFileBrowseButton = new System.Windows.Forms.Button();
        	this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        	this.backupFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem1,
        	        	        	this.optionsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
        	this.mainMenuStrip.TabIndex = 51;
        	// 
        	// fileToolStripMenuItem1
        	// 
        	this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem1,
        	        	        	this.toolStripSeparator3,
        	        	        	this.exitToolStripMenuItem1});
        	this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        	this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem1.Text = "&File";
        	// 
        	// newToolStripMenuItem1
        	// 
        	this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
        	this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
        	this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
        	this.newToolStripMenuItem1.Text = "&New";
        	this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem1
        	// 
        	this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
        	this.exitToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem1.Text = "E&xit";
        	this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitToolStripMenuItem1Click);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem,
        	        	        	this.backupFilesToolStripMenuItem,
        	        	        	this.checkOnClickToolStripMenuItem,
        	        	        	this.loadFilesOnStartToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// checkOnClickToolStripMenuItem
        	// 
        	this.checkOnClickToolStripMenuItem.Checked = true;
        	this.checkOnClickToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.checkOnClickToolStripMenuItem.Name = "checkOnClickToolStripMenuItem";
        	this.checkOnClickToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
        	this.checkOnClickToolStripMenuItem.Text = "&Check on click";
        	// 
        	// loadFilesOnStartToolStripMenuItem
        	// 
        	this.loadFilesOnStartToolStripMenuItem.Checked = true;
        	this.loadFilesOnStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.loadFilesOnStartToolStripMenuItem.Name = "loadFilesOnStartToolStripMenuItem";
        	this.loadFilesOnStartToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
        	this.loadFilesOnStartToolStripMenuItem.Text = "&Load files on start";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.freeReleasesPublicDomainisToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// freeReleasesPublicDomainisToolStripMenuItem
        	// 
        	this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.totalToolStripStatusLabel,
        	        	        	this.totalCountToolStripStatusLabel,
        	        	        	this.doneToolStripStatusLabel,
        	        	        	this.doneCountToolStripStatusLabel,
        	        	        	this.toolStripProgressBar});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 420);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 50;
        	// 
        	// totalToolStripStatusLabel
        	// 
        	this.totalToolStripStatusLabel.Name = "totalToolStripStatusLabel";
        	this.totalToolStripStatusLabel.Size = new System.Drawing.Size(37, 17);
        	this.totalToolStripStatusLabel.Text = "Total:";
        	// 
        	// totalCountToolStripStatusLabel
        	// 
        	this.totalCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.totalCountToolStripStatusLabel.Name = "totalCountToolStripStatusLabel";
        	this.totalCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.totalCountToolStripStatusLabel.Text = "0";
        	// 
        	// doneToolStripStatusLabel
        	// 
        	this.doneToolStripStatusLabel.Name = "doneToolStripStatusLabel";
        	this.doneToolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
        	this.doneToolStripStatusLabel.Text = "Done:";
        	// 
        	// doneCountToolStripStatusLabel
        	// 
        	this.doneCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.doneCountToolStripStatusLabel.Name = "doneCountToolStripStatusLabel";
        	this.doneCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.doneCountToolStripStatusLabel.Text = "0";
        	// 
        	// toolStripProgressBar
        	// 
        	this.toolStripProgressBar.Name = "toolStripProgressBar";
        	this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
        	this.toolStripProgressBar.Visible = false;
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 2;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.mainTableLayoutPanel.Controls.Add(this.intermediateFileTextBox, 0, 7);
        	this.mainTableLayoutPanel.Controls.Add(this.intermediateFileLabel, 0, 6);
        	this.mainTableLayoutPanel.Controls.Add(this.scriptProgramTextBox, 0, 5);
        	this.mainTableLayoutPanel.Controls.Add(this.scriptProgramLabel, 0, 4);
        	this.mainTableLayoutPanel.Controls.Add(this.rootDirectoryLabel, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.rootDirectoryBrowseButton, 1, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.rootDirectoryTextBox, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.loadFilesButton, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.filesCheckedListBox, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.scriptProgramButton, 1, 5);
        	this.mainTableLayoutPanel.Controls.Add(this.processButton, 0, 8);
        	this.mainTableLayoutPanel.Controls.Add(this.intermediateFileBrowseButton, 1, 7);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 9;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 396);
        	this.mainTableLayoutPanel.TabIndex = 52;
        	// 
        	// intermediateFileTextBox
        	// 
        	this.intermediateFileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.intermediateFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.intermediateFileTextBox.Location = new System.Drawing.Point(1, 337);
        	this.intermediateFileTextBox.Margin = new System.Windows.Forms.Padding(1);
        	this.intermediateFileTextBox.Name = "intermediateFileTextBox";
        	this.intermediateFileTextBox.Size = new System.Drawing.Size(211, 22);
        	this.intermediateFileTextBox.TabIndex = 9;
        	// 
        	// intermediateFileLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.intermediateFileLabel, 2);
        	this.intermediateFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.intermediateFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.intermediateFileLabel.Location = new System.Drawing.Point(3, 311);
        	this.intermediateFileLabel.Name = "intermediateFileLabel";
        	this.intermediateFileLabel.Size = new System.Drawing.Size(278, 25);
        	this.intermediateFileLabel.TabIndex = 8;
        	this.intermediateFileLabel.Text = "&Intermediate file:";
        	this.intermediateFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// scriptProgramTextBox
        	// 
        	this.scriptProgramTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.scriptProgramTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.scriptProgramTextBox.Location = new System.Drawing.Point(1, 282);
        	this.scriptProgramTextBox.Margin = new System.Windows.Forms.Padding(1);
        	this.scriptProgramTextBox.Name = "scriptProgramTextBox";
        	this.scriptProgramTextBox.Size = new System.Drawing.Size(211, 22);
        	this.scriptProgramTextBox.TabIndex = 6;
        	// 
        	// scriptProgramLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.scriptProgramLabel, 2);
        	this.scriptProgramLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.scriptProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.scriptProgramLabel.Location = new System.Drawing.Point(3, 256);
        	this.scriptProgramLabel.Name = "scriptProgramLabel";
        	this.scriptProgramLabel.Size = new System.Drawing.Size(278, 25);
        	this.scriptProgramLabel.TabIndex = 5;
        	this.scriptProgramLabel.Text = "&Script/program:";
        	this.scriptProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// rootDirectoryLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.rootDirectoryLabel, 2);
        	this.rootDirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rootDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.rootDirectoryLabel.Location = new System.Drawing.Point(3, 0);
        	this.rootDirectoryLabel.Name = "rootDirectoryLabel";
        	this.rootDirectoryLabel.Size = new System.Drawing.Size(278, 25);
        	this.rootDirectoryLabel.TabIndex = 0;
        	this.rootDirectoryLabel.Text = "&Root directory:";
        	this.rootDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// rootDirectoryBrowseButton
        	// 
        	this.rootDirectoryBrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rootDirectoryBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.rootDirectoryBrowseButton.Location = new System.Drawing.Point(214, 26);
        	this.rootDirectoryBrowseButton.Margin = new System.Windows.Forms.Padding(1);
        	this.rootDirectoryBrowseButton.Name = "rootDirectoryBrowseButton";
        	this.rootDirectoryBrowseButton.Size = new System.Drawing.Size(69, 28);
        	this.rootDirectoryBrowseButton.TabIndex = 2;
        	this.rootDirectoryBrowseButton.Text = "&Browse";
        	this.rootDirectoryBrowseButton.UseVisualStyleBackColor = true;
        	this.rootDirectoryBrowseButton.Click += new System.EventHandler(this.OnRootDirectoryBrowseButtonClick);
        	// 
        	// rootDirectoryTextBox
        	// 
        	this.rootDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rootDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.rootDirectoryTextBox.Location = new System.Drawing.Point(1, 26);
        	this.rootDirectoryTextBox.Margin = new System.Windows.Forms.Padding(1);
        	this.rootDirectoryTextBox.Name = "rootDirectoryTextBox";
        	this.rootDirectoryTextBox.Size = new System.Drawing.Size(211, 22);
        	this.rootDirectoryTextBox.TabIndex = 1;
        	// 
        	// loadFilesButton
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.loadFilesButton, 2);
        	this.loadFilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.loadFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.loadFilesButton.ForeColor = System.Drawing.Color.DarkBlue;
        	this.loadFilesButton.Location = new System.Drawing.Point(1, 56);
        	this.loadFilesButton.Margin = new System.Windows.Forms.Padding(1);
        	this.loadFilesButton.Name = "loadFilesButton";
        	this.loadFilesButton.Size = new System.Drawing.Size(282, 28);
        	this.loadFilesButton.TabIndex = 3;
        	this.loadFilesButton.Text = "&Load files";
        	this.loadFilesButton.UseVisualStyleBackColor = true;
        	this.loadFilesButton.Click += new System.EventHandler(this.OnLoadFilesButtonClick);
        	// 
        	// filesCheckedListBox
        	// 
        	this.filesCheckedListBox.CheckOnClick = true;
        	this.mainTableLayoutPanel.SetColumnSpan(this.filesCheckedListBox, 2);
        	this.filesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.filesCheckedListBox.FormattingEnabled = true;
        	this.filesCheckedListBox.Location = new System.Drawing.Point(3, 88);
        	this.filesCheckedListBox.Name = "filesCheckedListBox";
        	this.filesCheckedListBox.Size = new System.Drawing.Size(278, 165);
        	this.filesCheckedListBox.TabIndex = 4;
        	this.filesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnFilesCheckedListBoxItemCheck);
        	// 
        	// scriptProgramButton
        	// 
        	this.scriptProgramButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.scriptProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
        	this.scriptProgramButton.Location = new System.Drawing.Point(214, 282);
        	this.scriptProgramButton.Margin = new System.Windows.Forms.Padding(1);
        	this.scriptProgramButton.Name = "scriptProgramButton";
        	this.scriptProgramButton.Size = new System.Drawing.Size(69, 28);
        	this.scriptProgramButton.TabIndex = 7;
        	this.scriptProgramButton.Text = "&Browse";
        	this.scriptProgramButton.UseVisualStyleBackColor = true;
        	this.scriptProgramButton.Click += new System.EventHandler(this.OnScriptProgramButtonClick);
        	// 
        	// processButton
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.processButton, 2);
        	this.processButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.processButton.ForeColor = System.Drawing.Color.DarkBlue;
        	this.processButton.Location = new System.Drawing.Point(3, 364);
        	this.processButton.Name = "processButton";
        	this.processButton.Size = new System.Drawing.Size(278, 29);
        	this.processButton.TabIndex = 11;
        	this.processButton.Text = "&PROCESS";
        	this.processButton.UseVisualStyleBackColor = true;
        	this.processButton.Click += new System.EventHandler(this.OnProcessButtonClick);
        	// 
        	// intermediateFileBrowseButton
        	// 
        	this.intermediateFileBrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.intermediateFileBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
        	this.intermediateFileBrowseButton.Location = new System.Drawing.Point(214, 337);
        	this.intermediateFileBrowseButton.Margin = new System.Windows.Forms.Padding(1);
        	this.intermediateFileBrowseButton.Name = "intermediateFileBrowseButton";
        	this.intermediateFileBrowseButton.Size = new System.Drawing.Size(69, 23);
        	this.intermediateFileBrowseButton.TabIndex = 10;
        	this.intermediateFileBrowseButton.Text = "&Browse";
        	this.intermediateFileBrowseButton.UseVisualStyleBackColor = true;
        	this.intermediateFileBrowseButton.Click += new System.EventHandler(this.OnIntermediateFileBrowseButtonClick);
        	// 
        	// openFileDialog
        	// 
        	this.openFileDialog.Filter = "All files|*.*";
        	// 
        	// folderBrowserDialog
        	// 
        	this.folderBrowserDialog.Description = "Set root directory";
        	// 
        	// backupFilesToolStripMenuItem
        	// 
        	this.backupFilesToolStripMenuItem.Checked = true;
        	this.backupFilesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.backupFilesToolStripMenuItem.Name = "backupFilesToolStripMenuItem";
        	this.backupFilesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
        	this.backupFilesToolStripMenuItem.Text = "&Backup files";
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(284, 442);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "nkNameFlip";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
        	this.Load += new System.EventHandler(this.OnMainFormLoad);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.mainTableLayoutPanel.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem backupFilesToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem checkOnClickToolStripMenuItem;
        private System.Windows.Forms.Button intermediateFileBrowseButton;
        private System.Windows.Forms.ToolStripMenuItem loadFilesOnStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label intermediateFileLabel;
        private System.Windows.Forms.TextBox intermediateFileTextBox;
        private System.Windows.Forms.Button scriptProgramButton;
        private System.Windows.Forms.CheckedListBox filesCheckedListBox;
        private System.Windows.Forms.Button loadFilesButton;
        private System.Windows.Forms.TextBox rootDirectoryTextBox;
        private System.Windows.Forms.Button rootDirectoryBrowseButton;
        private System.Windows.Forms.Label rootDirectoryLabel;
        private System.Windows.Forms.Label scriptProgramLabel;
        private System.Windows.Forms.TextBox scriptProgramTextBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel doneCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel doneToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
