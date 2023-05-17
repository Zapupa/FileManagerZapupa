
namespace FileManagerZapupa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalDriveSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeDriveSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.driveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDrive = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesDrive = new System.Windows.Forms.ToolStripMenuItem();
            this.folderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.packFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.copyArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.folderInsideMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFolderInsideMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCreateFolderInsideMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.folderCreateFolderInsideMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            this.driveMenu.SuspendLayout();
            this.folderMenu.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.archiveMenu.SuspendLayout();
            this.folderInsideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderName,
            this.Type,
            this.TotalDriveSpace,
            this.FreeDriveSpace});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(829, 400);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // ColumnHeaderName
            // 
            this.ColumnHeaderName.Text = "Name";
            this.ColumnHeaderName.Width = 187;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 222;
            // 
            // TotalDriveSpace
            // 
            this.TotalDriveSpace.Text = "Size";
            this.TotalDriveSpace.Width = 187;
            // 
            // FreeDriveSpace
            // 
            this.FreeDriveSpace.Text = "Last Modified";
            this.FreeDriveSpace.Width = 211;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            this.iconList.Images.SetKeyName(1, "folder2.png");
            this.iconList.Images.SetKeyName(2, "file.png");
            this.iconList.Images.SetKeyName(3, "doc.png");
            this.iconList.Images.SetKeyName(4, "pdf.png");
            this.iconList.Images.SetKeyName(5, "mp3.png");
            this.iconList.Images.SetKeyName(6, "mp4.png");
            this.iconList.Images.SetKeyName(7, "exe.png");
            this.iconList.Images.SetKeyName(8, "unknown.png");
            this.iconList.Images.SetKeyName(9, "png.png");
            this.iconList.Images.SetKeyName(10, "folder64.png");
            this.iconList.Images.SetKeyName(11, "hard-disk.png");
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(7, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 23);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(623, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(33, 23);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnForward.TabIndex = 3;
            this.btnForward.TabStop = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 458);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Элементов:";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filePathTextBox.Location = new System.Drawing.Point(244, 13);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(373, 23);
            this.filePathTextBox.TabIndex = 5;
            // 
            // driveMenu
            // 
            this.driveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDrive,
            this.propertiesDrive});
            this.driveMenu.Name = "contextMenuStrip1";
            this.driveMenu.Size = new System.Drawing.Size(128, 48);
            // 
            // openDrive
            // 
            this.openDrive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.openDrive.Name = "openDrive";
            this.openDrive.Size = new System.Drawing.Size(127, 22);
            this.openDrive.Text = "Open";
            this.openDrive.Click += new System.EventHandler(this.openDrive_Click);
            // 
            // propertiesDrive
            // 
            this.propertiesDrive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.propertiesDrive.Name = "propertiesDrive";
            this.propertiesDrive.Size = new System.Drawing.Size(127, 22);
            this.propertiesDrive.Text = "properties";
            this.propertiesDrive.Click += new System.EventHandler(this.propertiesDrive_Click);
            // 
            // folderMenu
            // 
            this.folderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolder,
            this.packFolder,
            this.deleteFolder,
            this.copyFolder,
            this.propertiesFolder});
            this.folderMenu.Name = "contextMenuStrip1";
            this.folderMenu.Size = new System.Drawing.Size(128, 114);
            // 
            // openFolder
            // 
            this.openFolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(127, 22);
            this.openFolder.Text = "Open";
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // packFolder
            // 
            this.packFolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.packFolder.Name = "packFolder";
            this.packFolder.Size = new System.Drawing.Size(127, 22);
            this.packFolder.Text = "Pack";
            this.packFolder.Click += new System.EventHandler(this.packFolder_Click);
            // 
            // deleteFolder
            // 
            this.deleteFolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.deleteFolder.Name = "deleteFolder";
            this.deleteFolder.Size = new System.Drawing.Size(127, 22);
            this.deleteFolder.Text = "Delete";
            this.deleteFolder.Click += new System.EventHandler(this.deleteFolder_Click);
            // 
            // copyFolder
            // 
            this.copyFolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.copyFolder.Name = "copyFolder";
            this.copyFolder.Size = new System.Drawing.Size(127, 22);
            this.copyFolder.Text = "Move to";
            this.copyFolder.Click += new System.EventHandler(this.copyFolder_Click);
            // 
            // propertiesFolder
            // 
            this.propertiesFolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.propertiesFolder.Name = "propertiesFolder";
            this.propertiesFolder.Size = new System.Drawing.Size(127, 22);
            this.propertiesFolder.Text = "Properties";
            this.propertiesFolder.Click += new System.EventHandler(this.propertiesFolder_Click);
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.deleteFile,
            this.copyFile,
            this.propertiesFiles});
            this.fileMenu.Name = "contextMenuStrip1";
            this.fileMenu.Size = new System.Drawing.Size(128, 92);
            // 
            // openFile
            // 
            this.openFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(127, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(127, 22);
            this.deleteFile.Text = "Delete";
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // copyFile
            // 
            this.copyFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(127, 22);
            this.copyFile.Text = "Copy to";
            this.copyFile.Click += new System.EventHandler(this.copyFile_Click);
            // 
            // propertiesFiles
            // 
            this.propertiesFiles.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.propertiesFiles.Name = "propertiesFiles";
            this.propertiesFiles.Size = new System.Drawing.Size(127, 22);
            this.propertiesFiles.Text = "Properties";
            this.propertiesFiles.Click += new System.EventHandler(this.propertiesFiles_Click);
            // 
            // archiveMenu
            // 
            this.archiveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openArchive,
            this.unpackArchive,
            this.deleteArchive,
            this.copyArchive,
            this.propertiesArchive});
            this.archiveMenu.Name = "contextMenuStrip1";
            this.archiveMenu.Size = new System.Drawing.Size(128, 114);
            // 
            // openArchive
            // 
            this.openArchive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.openArchive.Name = "openArchive";
            this.openArchive.Size = new System.Drawing.Size(127, 22);
            this.openArchive.Text = "Open";
            this.openArchive.Click += new System.EventHandler(this.openArchive_Click);
            // 
            // unpackArchive
            // 
            this.unpackArchive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.unpackArchive.Name = "unpackArchive";
            this.unpackArchive.Size = new System.Drawing.Size(127, 22);
            this.unpackArchive.Text = "Unpack";
            this.unpackArchive.Click += new System.EventHandler(this.unpackArchive_Click);
            // 
            // deleteArchive
            // 
            this.deleteArchive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.deleteArchive.Name = "deleteArchive";
            this.deleteArchive.Size = new System.Drawing.Size(127, 22);
            this.deleteArchive.Text = "Delete";
            this.deleteArchive.Click += new System.EventHandler(this.deleteArchive_Click);
            // 
            // copyArchive
            // 
            this.copyArchive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.copyArchive.Name = "copyArchive";
            this.copyArchive.Size = new System.Drawing.Size(127, 22);
            this.copyArchive.Text = "Copy to";
            this.copyArchive.Click += new System.EventHandler(this.copyArchive_Click);
            // 
            // propertiesArchive
            // 
            this.propertiesArchive.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.propertiesArchive.Name = "propertiesArchive";
            this.propertiesArchive.Size = new System.Drawing.Size(127, 22);
            this.propertiesArchive.Text = "Properties";
            this.propertiesArchive.Click += new System.EventHandler(this.propertiesArchive_Click);
            // 
            // folderInsideMenu
            // 
            this.folderInsideMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFolderInsideMenu});
            this.folderInsideMenu.Name = "contextMenuStrip1";
            this.folderInsideMenu.Size = new System.Drawing.Size(109, 26);
            // 
            // createFolderInsideMenu
            // 
            this.createFolderInsideMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCreateFolderInsideMenu,
            this.folderCreateFolderInsideMenu});
            this.createFolderInsideMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.createFolderInsideMenu.Name = "createFolderInsideMenu";
            this.createFolderInsideMenu.Size = new System.Drawing.Size(108, 22);
            this.createFolderInsideMenu.Text = "Create";
            // 
            // fileCreateFolderInsideMenu
            // 
            this.fileCreateFolderInsideMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fileCreateFolderInsideMenu.Name = "fileCreateFolderInsideMenu";
            this.fileCreateFolderInsideMenu.Size = new System.Drawing.Size(107, 22);
            this.fileCreateFolderInsideMenu.Text = "File";
            this.fileCreateFolderInsideMenu.Click += new System.EventHandler(this.fileCreateFolderInsideMenu_Click);
            // 
            // folderCreateFolderInsideMenu
            // 
            this.folderCreateFolderInsideMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.folderCreateFolderInsideMenu.Name = "folderCreateFolderInsideMenu";
            this.folderCreateFolderInsideMenu.Size = new System.Drawing.Size(107, 22);
            this.folderCreateFolderInsideMenu.Text = "Folder";
            this.folderCreateFolderInsideMenu.Click += new System.EventHandler(this.folderCreateFolderInsideMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 480);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            this.driveMenu.ResumeLayout(false);
            this.folderMenu.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.archiveMenu.ResumeLayout(false);
            this.folderInsideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnHeaderName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader TotalDriveSpace;
        private System.Windows.Forms.ColumnHeader FreeDriveSpace;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.ContextMenuStrip driveMenu;
        private System.Windows.Forms.ToolStripMenuItem openDrive;
        private System.Windows.Forms.ContextMenuStrip folderMenu;
        private System.Windows.Forms.ToolStripMenuItem propertiesDrive;
        private System.Windows.Forms.ToolStripMenuItem openFolder;
        private System.Windows.Forms.ToolStripMenuItem packFolder;
        private System.Windows.Forms.ToolStripMenuItem deleteFolder;
        private System.Windows.Forms.ToolStripMenuItem copyFolder;
        private System.Windows.Forms.ToolStripMenuItem propertiesFolder;
        private System.Windows.Forms.ContextMenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem deleteFile;
        private System.Windows.Forms.ToolStripMenuItem copyFile;
        private System.Windows.Forms.ToolStripMenuItem propertiesFiles;
        private System.Windows.Forms.ContextMenuStrip archiveMenu;
        private System.Windows.Forms.ToolStripMenuItem openArchive;
        private System.Windows.Forms.ToolStripMenuItem unpackArchive;
        private System.Windows.Forms.ToolStripMenuItem deleteArchive;
        private System.Windows.Forms.ToolStripMenuItem copyArchive;
        private System.Windows.Forms.ToolStripMenuItem propertiesArchive;
        private System.Windows.Forms.ContextMenuStrip folderInsideMenu;
        private System.Windows.Forms.ToolStripMenuItem createFolderInsideMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCreateFolderInsideMenu;
        private System.Windows.Forms.ToolStripMenuItem folderCreateFolderInsideMenu;
    }
}

