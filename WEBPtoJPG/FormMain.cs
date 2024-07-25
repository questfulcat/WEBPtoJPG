using System;
using System.IO;
using System.Windows.Forms;

namespace WEBPtoJPG
{
    public partial class FormMain : Form
    {
        const string appVersion = "0.2";

        Converter converter;
        Settings settings = new Settings();
        
        public FormMain()
        {
            InitializeComponent();
            converter = new Converter(log);
            this.Text += " v" + appVersion; 

            loadSettings();
            this.FormClosing += (s, e) => saveSettings();

            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && File.Exists(args[1])) converter.AddFile(args[1]);

            for (int c = 2; c < args.Length; c++)
            {
                if (args[c] == "-auto")
                {
                    converter.ConvertFiles((int)numericUpDownJPEGQuality.Value, checkBoxDeleteSources.Checked, true);
                    Close();
                }
                if (args[c] == "-autoall")
                {
                    converter.ScanFolder(false);
                    converter.ConvertFiles((int)numericUpDownJPEGQuality.Value, checkBoxDeleteSources.Checked, true);
                    Close();
                }
            }
            updateFileList();
        }

        void loadSettings()
        {
            try
            {
                settings.Load();
                checkBoxDeleteSources.Checked = settings.DeleteSources;
                numericUpDownJPEGQuality.Value = settings.JPEGQuality;
            }
            catch (Exception exc) { MessageBox.Show("Failed to load app settings\r\n" + exc.Message); }
        }

        void saveSettings()
        {
            try
            {
                settings.DeleteSources = checkBoxDeleteSources.Checked;
                settings.JPEGQuality = (int)numericUpDownJPEGQuality.Value;
                settings.Save();
            }
            catch (Exception exc) { MessageBox.Show("Failed to save app settings\r\n" + exc.Message); }
        }
        
        void log(string msg)
        {
            listBoxOutput.Items.Add(msg);
            listBoxOutput.TopIndex = listBoxOutput.Items.Count - 1;
        }

        void updateFileList()
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(converter.GetFiles());
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            converter.ConvertFiles((int)numericUpDownJPEGQuality.Value, checkBoxDeleteSources.Checked, false);
            updateFileList();
        }
        
        OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, Filter = "WEBP files|*.webp" };
        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK) return;
            foreach (var file in ofd.FileNames) converter.AddFile(file);
            updateFileList();
        }

        private void buttonScanFolder_Click(object sender, EventArgs e)
        {
            if (converter.FilesCount() < 1) { MessageBox.Show("You have to add first webp file then use this button, it will add other webp files from same folder"); return; }
            converter.ScanFolder(false);
            updateFileList();
        }

        private void buttonScanFoldersRecursively_Click(object sender, EventArgs e)
        {
            if (converter.FilesCount() < 1) { MessageBox.Show("You have to add first webp file then use this button, it will add other webp files from same folder and subfolders"); return; }
            converter.ScanFolder(true);
            updateFileList();
        }

        private void buttonClearFilelist_Click(object sender, EventArgs e)
        {
            converter.Clear();
            updateFileList();
        }

        private void buttonAddContextMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add windows context menu item 'convert' for webp files?", "Accept", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            Utils.SetWEBPExtensionContextMenu();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Version {appVersion}\r\n2024 MIT License\r\ndeveloper: questfulcat\r\nhttps://github.com/questfulcat/webptojpg", "WEBP to JPG (GUI for dwebp)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
