// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace nkNameFlip
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        public SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:nkNameFlip.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            /* Process settings */

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            /* Set GUI */

            // Text boxes
            this.rootDirectoryTextBox.Text = this.settingsData.RootDirectory;
            this.scriptProgramTextBox.Text = this.settingsData.ScriptProgram;
            this.intermediateFileTextBox.Text = this.settingsData.IntermediateFile;

            // Options
            this.alwaysOnTopToolStripMenuItem.Checked = this.settingsData.TopMost;
            this.checkOnClickToolStripMenuItem.Checked = this.settingsData.CheckOnClick;
            this.backupFilesToolStripMenuItem.Checked = this.settingsData.BackupFiles;
            this.loadFilesOnStartToolStripMenuItem.Checked = this.settingsData.LoadFilesOnStart;
        }

        /// <summary>
        // Handles the root directory browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRootDirectoryBrowseButtonClick(object sender, EventArgs e)
        {
            // Set description
            this.folderBrowserDialog.Description = "Set root directory";

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Set to text box
                this.rootDirectoryTextBox.Text = this.folderBrowserDialog.SelectedPath;

                // Load files
                this.loadFilesButton.PerformClick();
            }
        }

        /// <summary>
        // Handles the load files button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLoadFilesButtonClick(object sender, EventArgs e)
        {
            // Folder check
            if (this.rootDirectoryTextBox.Text.Length > 0 && Directory.Exists(this.rootDirectoryTextBox.Text))
            {
                // Prevent drawing
                this.filesCheckedListBox.BeginUpdate();

                // Clear list
                this.filesCheckedListBox.Items.Clear();

                // Browse subfolders
                foreach (var subfolder in Directory.GetDirectories(this.rootDirectoryTextBox.Text, "*", SearchOption.TopDirectoryOnly))
                {
                    // Populate list
                    foreach (string file in Directory.GetFiles(this.rootDirectoryTextBox.Text, "*", SearchOption.TopDirectoryOnly))
                    {
                        // Add current file
                        this.filesCheckedListBox.Items.Add(file, true);
                    }
                }

                // Resume drawing
                this.filesCheckedListBox.EndUpdate();
            }
            else
            {
                // Advise user
                MessageBox.Show("Invalid root directory.", "Load files", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        // Handles the script program button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScriptProgramButtonClick(object sender, EventArgs e)
        {
            // Set open file dialog
            this.openFileDialog.Title = "Open script/program";
            this.openFileDialog.CheckFileExists = true;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set text box
                this.scriptProgramTextBox.Text = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        // Handles the intermediate file browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnIntermediateFileBrowseButtonClick(object sender, EventArgs e)
        {
            // Set open file dialog
            this.openFileDialog.Title = "Set intermediate file";
            this.openFileDialog.CheckFileExists = false;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set text box
                this.intermediateFileTextBox.Text = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        // Handles the process button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnProcessButtonClick(object sender, EventArgs e)
        {
            /* Checks */

            // Check root directory
            if (this.rootDirectoryTextBox.Text.Length == 0 || !Directory.Exists(this.rootDirectoryTextBox.Text))
            {
                // Advise user
                MessageBox.Show("Please enter a valid root directory.", "Root directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus text box
                this.rootDirectoryTextBox.Focus();

                // Halt flow
                return;
            }

            // Check there are files to work with
            if (this.filesCheckedListBox.Items.Count == 0 || this.filesCheckedListBox.CheckedItems.Count == 0)
            {
                // Advise user
                MessageBox.Show("Please add files to work with.", "Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus text box
                this.loadFilesButton.Focus();

                // Halt flow
                return;
            }

            // Check script/program
            if (this.scriptProgramTextBox.Text.Length == 0 || !File.Exists(this.scriptProgramTextBox.Text))
            {
                // Advise user
                MessageBox.Show("Please enter a valid script/program file.", "Script / Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus text box
                this.scriptProgramTextBox.Focus();

                // Halt flow
                return;
            }

            // Check intermediate file directory exists
            if (this.intermediateFileTextBox.Text.Length == 0 || !Directory.Exists(Path.GetDirectoryName(this.intermediateFileTextBox.Text)))
            {
                // Advise user
                MessageBox.Show("Invalid directory for internmediate file.", "Intermediate file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus text box
                this.intermediateFileTextBox.Focus();

                // Halt flow
                return;
            }

            // Check script and intermediate files are different
            if (this.intermediateFileTextBox.Text == this.scriptProgramTextBox.Text)
            {
                // Advise user
                MessageBox.Show("Script and internmediate file must be different.", "Same file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus text box
                this.intermediateFileTextBox.Focus();

                // Halt flow
                return;
            }

            /* Processing */

            // Disable button
            this.processButton.Enabled = false;

            // Current checked file (for error log)
            string currentCheckedFile = string.Empty;

            // Error counter
            int errors = 0;

            try
            {
                // Iterate checked items / files
                foreach (var checkedFile in this.filesCheckedListBox.CheckedItems)
                {
                    // Set current checked file
                    currentCheckedFile = checkedFile.ToString();

                    // Backup current file
                    if (this.backupFilesToolStripMenuItem.Checked)
                    {
                        // Set backup directory
                        string backupdirectory = Path.Combine(Path.GetDirectoryName(currentCheckedFile), "backup");

                        // Create backup directory
                        Directory.CreateDirectory(backupdirectory);

                        // Copy unix-timestamped file
                        File.Copy(currentCheckedFile, Path.Combine(backupdirectory, $"{(int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds}-{Path.GetFileName(currentCheckedFile)}"), true);
                    }

                    // Copy file
                    File.Copy(currentCheckedFile, this.intermediateFileTextBox.Text, true);

                    // Run script/program and wait for it to finish
                    Process.Start(this.scriptProgramTextBox.Text).WaitForExit();

                    // Copy resulting file back
                    File.Copy(this.intermediateFileTextBox.Text, currentCheckedFile, true);
                }
            }
            catch (Exception ex)
            {
                // Raise error cuont
                errors++;

                // Log error
                File.AppendAllText("nkNameFlip-ErrorLog.txt", $"{Environment.NewLine}{Environment.NewLine}File: {currentCheckedFile}{Environment.NewLine}Script: {this.scriptProgramTextBox.Text}{Environment.NewLine}Intermediate file: {this.intermediateFileTextBox.Text}{Environment.NewLine}Message: {ex.Message}");
            }

            // Update status
            this.UpdateStatus(this.filesCheckedListBox.CheckedItems.Count - errors);

            // Advise
            MessageBox.Show($"Processing finished!{(errors > 0 ? $"{Environment.NewLine}{errors} errors." : string.Empty)}", "Done", MessageBoxButtons.OK, errors > 0 ? MessageBoxIcon.Error : MessageBoxIcon.Information);

            // Enable button
            this.processButton.Enabled = true;
        }

        /// <summary>
        // Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        // Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear text boxes
            this.rootDirectoryTextBox.Clear();
            this.scriptProgramTextBox.Clear();
            this.intermediateFileTextBox.Clear();

            // Check checked list box
            this.filesCheckedListBox.Items.Clear();

            // Update status
            this.UpdateStatus(0);

            // Focus root directory text box
            this.rootDirectoryTextBox.Focus();
        }

        /// <summary>
        // Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        // Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=52177.0");
        }

        /// <summary>
        // Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/nknameflip");
        }

        /// <summary>
        // Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Arrow icon by OpenClipart-Vectors - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/arrow-red-turn-turn-over-reverse-147078/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: nkormanik{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #90, Week #13 @ March 31, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        // Handles the files checked list box item check.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFilesCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update status
            this.UpdateStatus(0);
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="doneCount">Done count.</param>
        private void UpdateStatus(int doneCount)
        {
            // Update total count
            this.totalCountToolStripStatusLabel.Text = this.filesCheckedListBox.CheckedItems.Count.ToString();

            // Reset done count
            this.doneCountToolStripStatusLabel.Text = doneCount.ToString();
        }

        /// <summary>
        /// Ons the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            /* Set settings data from GUI */

            // Text boxes
            this.settingsData.RootDirectory = this.rootDirectoryTextBox.Text;
            this.settingsData.ScriptProgram = this.scriptProgramTextBox.Text;
            this.settingsData.IntermediateFile = this.intermediateFileTextBox.Text;

            // Options
            this.settingsData.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
            this.settingsData.CheckOnClick = this.checkOnClickToolStripMenuItem.Checked;
            this.settingsData.BackupFiles = this.backupFilesToolStripMenuItem.Checked;
            this.settingsData.LoadFilesOnStart = this.loadFilesOnStartToolStripMenuItem.Checked;

            // Save to disk 
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Ons the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Load files
            if (this.settingsData.LoadFilesOnStart && Directory.Exists(this.settingsData.RootDirectory))
            {
                // Hack Ensure root directory is set [Mono, Linux]
                this.rootDirectoryTextBox.Text = this.settingsData.RootDirectory;

                // Click load files button
                this.loadFilesButton.PerformClick();
            }

            // Hack Topmost on start [DEBUG]
            this.TopMost = this.settingsData.TopMost;
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        // Handles the exit tool strip menu item1 click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItem1Click(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
