namespace WEBPtoJPG
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownJPEGQuality = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDeleteSources = new System.Windows.Forms.CheckBox();
            this.buttonScanFoldersRecursively = new System.Windows.Forms.Button();
            this.buttonScanFolder = new System.Windows.Forms.Button();
            this.buttonClearFilelist = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.buttonAddContextMenu = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAbout = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJPEGQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(0, 284);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(800, 166);
            this.listBoxOutput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownJPEGQuality);
            this.panel1.Controls.Add(this.checkBoxDeleteSources);
            this.panel1.Controls.Add(this.buttonScanFoldersRecursively);
            this.panel1.Controls.Add(this.buttonScanFolder);
            this.panel1.Controls.Add(this.buttonClearFilelist);
            this.panel1.Controls.Add(this.buttonAddFiles);
            this.panel1.Controls.Add(this.buttonAbout);
            this.panel1.Controls.Add(this.buttonAddContextMenu);
            this.panel1.Controls.Add(this.buttonConvert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDownJPEGQuality
            // 
            this.numericUpDownJPEGQuality.Location = new System.Drawing.Point(481, 15);
            this.numericUpDownJPEGQuality.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownJPEGQuality.Name = "numericUpDownJPEGQuality";
            this.numericUpDownJPEGQuality.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownJPEGQuality.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numericUpDownJPEGQuality, "JPEG quality");
            this.numericUpDownJPEGQuality.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // checkBoxDeleteSources
            // 
            this.checkBoxDeleteSources.AutoSize = true;
            this.checkBoxDeleteSources.Checked = true;
            this.checkBoxDeleteSources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteSources.Location = new System.Drawing.Point(378, 16);
            this.checkBoxDeleteSources.Name = "checkBoxDeleteSources";
            this.checkBoxDeleteSources.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDeleteSources.TabIndex = 1;
            this.checkBoxDeleteSources.Text = "Delete sources";
            this.toolTip1.SetToolTip(this.checkBoxDeleteSources, "Delete source webp files after conversion");
            this.checkBoxDeleteSources.UseVisualStyleBackColor = true;
            // 
            // buttonScanFoldersRecursively
            // 
            this.buttonScanFoldersRecursively.Location = new System.Drawing.Point(249, 12);
            this.buttonScanFoldersRecursively.Name = "buttonScanFoldersRecursively";
            this.buttonScanFoldersRecursively.Size = new System.Drawing.Size(64, 22);
            this.buttonScanFoldersRecursively.TabIndex = 0;
            this.buttonScanFoldersRecursively.Text = "+Folders";
            this.toolTip1.SetToolTip(this.buttonScanFoldersRecursively, "Scan first file folder and subfolders recursively for webp files");
            this.buttonScanFoldersRecursively.UseVisualStyleBackColor = true;
            this.buttonScanFoldersRecursively.Click += new System.EventHandler(this.buttonScanFoldersRecursively_Click);
            // 
            // buttonScanFolder
            // 
            this.buttonScanFolder.Location = new System.Drawing.Point(191, 12);
            this.buttonScanFolder.Name = "buttonScanFolder";
            this.buttonScanFolder.Size = new System.Drawing.Size(52, 22);
            this.buttonScanFolder.TabIndex = 0;
            this.buttonScanFolder.Text = "+Folder";
            this.toolTip1.SetToolTip(this.buttonScanFolder, "Scan first file folder for new webp files");
            this.buttonScanFolder.UseVisualStyleBackColor = true;
            this.buttonScanFolder.Click += new System.EventHandler(this.buttonScanFolder_Click);
            // 
            // buttonClearFilelist
            // 
            this.buttonClearFilelist.Location = new System.Drawing.Point(319, 12);
            this.buttonClearFilelist.Name = "buttonClearFilelist";
            this.buttonClearFilelist.Size = new System.Drawing.Size(50, 22);
            this.buttonClearFilelist.TabIndex = 0;
            this.buttonClearFilelist.Text = "Clear";
            this.toolTip1.SetToolTip(this.buttonClearFilelist, "Clear selected files");
            this.buttonClearFilelist.UseVisualStyleBackColor = true;
            this.buttonClearFilelist.Click += new System.EventHandler(this.buttonClearFilelist_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(135, 12);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(50, 22);
            this.buttonAddFiles.TabIndex = 0;
            this.buttonAddFiles.Text = "Add";
            this.toolTip1.SetToolTip(this.buttonAddFiles, "Add new files");
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // buttonAddContextMenu
            // 
            this.buttonAddContextMenu.Location = new System.Drawing.Point(546, 12);
            this.buttonAddContextMenu.Name = "buttonAddContextMenu";
            this.buttonAddContextMenu.Size = new System.Drawing.Size(91, 22);
            this.buttonAddContextMenu.TabIndex = 0;
            this.buttonAddContextMenu.Text = "Add WCM";
            this.toolTip1.SetToolTip(this.buttonAddContextMenu, "Add windows context menu for webp file ext");
            this.buttonAddContextMenu.UseVisualStyleBackColor = true;
            this.buttonAddContextMenu.Click += new System.EventHandler(this.buttonAddContextMenu_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(12, 12);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 22);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.toolTip1.SetToolTip(this.buttonConvert, "Convert selected files");
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(643, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(61, 22);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 44);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(800, 234);
            this.listBoxFiles.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 278);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 6);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEBP to JPG (GUI for dwebp)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJPEGQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonScanFolder;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.NumericUpDown numericUpDownJPEGQuality;
        private System.Windows.Forms.CheckBox checkBoxDeleteSources;
        private System.Windows.Forms.Button buttonScanFoldersRecursively;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Button buttonAddContextMenu;
        private System.Windows.Forms.Button buttonClearFilelist;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Splitter splitter1;
    }
}

