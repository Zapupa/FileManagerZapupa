using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;

namespace FileManagerZapupa
{
    public enum ExtensionsForMenu
    {
        Drive,
        Folder,
        Archive,
        File,
        FolderInside
    }

    public partial class Form1 : Form
    {
        public static bool isFile = false;
        private bool isArchive = false;
        private string currentlySelectedItemName = "";
        private string filePath;
        public static bool root = true;
        private string operationPath;
        public static string propPath;
        private string drivePath;
        //private string prev ="";
        public Form1()
        {
            InitializeComponent();
            GetDrivesInfo();
        }
        public void GetDrivesInfo()
        {
            DrivesLayout();
            root = true;
            listView1.Items.Clear();
            var drives = DriveInfo.GetDrives();
            
            if (drives.Length <= 0)
            {
                return;
            }

            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item; 

            int counter=0;

            foreach (var drive in drives)
            {
                item = new ListViewItem($"{drive.VolumeLabel} ({drive.Name.Replace("\\","")})", 11);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, $"Drive - {drive.DriveType}"),
                    new ListViewItem.ListViewSubItem(item, $"{drive.TotalSize / Math.Pow(2, 30):f2} GBytes"),
                    new ListViewItem.ListViewSubItem(item, $"{drive.TotalFreeSpace/ Math.Pow(2, 30):f2} GBytes")};
                item.Name = drive.Name;
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);

                counter++;
            }

            labelCount.Text = $"Элементов: {counter}";

        }

        public void loadFilesAndDirectories()
        {
            //listView1.Items.Clear();

            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            var filePathKostil = $"{filePath}\\";
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);                  
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePathKostil);
                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {                 
                    fileList = new DirectoryInfo(filePathKostil);
                    FileInfo[] files = fileList.GetFiles(); 
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    int counter = files.Length + dirs.Length;
                    labelCount.Text = $"Элементов: {counter}";
                    string fileExtension = "";
                    listView1.Items.Clear();

                    ListViewItem.ListViewSubItem[] subItems;
                    ListViewItem item;
                                       
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        
                        switch (fileExtension)
                        {
                            case ".MP3":
                                item = new ListViewItem(files[i].Name, 5);
                                break;
                            
                            case ".EXE":
                                item = new ListViewItem(files[i].Name, 7);
                                break;
                            
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                item = new ListViewItem(files[i].Name, 6);
                                break;
                            
                            case ".PDF":
                                item = new ListViewItem(files[i].Name, 4);
                                break;
                            
                            case ".DOC":
                            case ".DOCX":
                                item = new ListViewItem(files[i].Name, 3);
                                break;
                            
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                item = new ListViewItem(files[i].Name, 9);
                                break;

                            default:
                                item = new ListViewItem(files[i].Name, 8);
                                break;
                        }
                        subItems = new ListViewItem.ListViewSubItem[]
                       {new ListViewItem.ListViewSubItem(item, $"{files[i].Extension}"),
                        new ListViewItem.ListViewSubItem(item, $"{files[i].Length / Math.Pow(2, 10):f1} KBytes."),
                        new ListViewItem.ListViewSubItem(item, $"{files[i].LastWriteTime}")};
                                                
                        item.SubItems.AddRange(subItems);
                        listView1.Items.Add(item);

                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        item = new ListViewItem(dirs[i].Name, 10);
                        subItems = new ListViewItem.ListViewSubItem[] {
                        new ListViewItem.ListViewSubItem(item, "Folder"),
                        new ListViewItem.ListViewSubItem(item, ""),
                        new ListViewItem.ListViewSubItem(item, $"{dirs[i].LastWriteTime}")};

                        item.SubItems.AddRange(subItems);
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()
        {

            if (root == true)
            {
                root = false;
                FilesAndDirectoriesLayout();
            }
            else
            {
                removeBackSlash();
            }

            
               
            filePath = filePathTextBox.Text;

            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var mouseKey = Control.MouseButtons;
            var mousePosition = Control.MousePosition;
            ExtensionsForMenu extension;


            if (root == true)
            {
                currentlySelectedItemName = e.Item.Name;
                filePathTextBox.Text = currentlySelectedItemName.Replace("\\", "");
                extension = ExtensionsForMenu.Drive;
            }
            else
            {
                try
                {
                    currentlySelectedItemName = e.Item.Text;
                    var fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
                    if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        isFile = false;
                        filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
                        extension = ExtensionsForMenu.Folder;
                    }
                    else
                    {
                        isFile = true;
                        var fileInfo = new FileInfo(filePath + "/" + currentlySelectedItemName);
                        
                        if(fileInfo.Extension == ".zip" || fileInfo.Extension == ".7z")
                            extension = ExtensionsForMenu.Archive;
                        else
                            extension = ExtensionsForMenu.File;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Данный файл недоступен");
                    return;
                }
            }

            var driveLetter = e.Item.Name;
            menuOpen(mouseKey, mousePosition, extension, driveLetter);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                removeBackSlash();
                string path = filePath;
                path = path.Substring(0, path.LastIndexOf("/"));
                isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
                loadButtonAction();                
            }
            catch (Exception ex)
            {
                filePathTextBox.Text = "";
                GetDrivesInfo();
            }
            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(filePathTextBox.Text != "")
            {
                loadButtonAction();
            }
            
        }

        private void DrivesLayout()
        {
            listView1.Columns[3].Text = "Free Space";
        }
        
        private void FilesAndDirectoriesLayout()
        {
            listView1.Columns[3].Text = "Last Modified";
        }

        #region Context Menu

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            var extension = ExtensionsForMenu.FolderInside;
            
            if (e.Button == MouseButtons.Right && !root)
            {
                folderInsideMenu.Show(this, new Point(e.X + 10, e.Y + 55));
            }            
        }

        private void menuOpen(MouseButtons e, Point mousePosition, ExtensionsForMenu extension, string driveLetter)
        {
            var xCoordinate = mousePosition.X - this.Left;
            var yCoordinate = mousePosition.Y - this.Top;
            
            if(e == MouseButtons.Right)
            {
                switch (extension)
                {
                    case ExtensionsForMenu.Drive:
                        {
                            drivePath = driveLetter;
                            //MessageBox.Show(driveLetter);

                            driveMenu.Show(this, new Point(xCoordinate - 5, yCoordinate - 30));
                        }
                        break;
                    case ExtensionsForMenu.Folder:
                        {
                            folderMenu.Show(this, new Point(xCoordinate - 5, yCoordinate - 30));
                        }
                        break;
                    case ExtensionsForMenu.File:
                        {
                            fileMenu.Show(this, new Point(xCoordinate - 5, yCoordinate - 30));
                        }
                        break;
                    case ExtensionsForMenu.Archive:
                        {
                            archiveMenu.Show(this, new Point(xCoordinate - 5, yCoordinate - 30));
                        }
                        break;
                }                                
            }
            
        }
        public void DeleteFile()
        {
            removeBackSlash();
            operationPath = filePath + "/" + currentlySelectedItemName;

            try
            {
                FileInfo = new FileInfo(operationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                var result = MessageBox.Show($"Вы действительно хотите удалить: {FileInfo.Name}?",
                $"Подтвердите удаление файла",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    FileInfo.Delete();
                }

                isFile = false;
                loadFilesAndDirectories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CopyFile()
        {
            removeBackSlash();
            operationPath = filePath + "/" + currentlySelectedItemName;

            try
            {
                FileInfo = new FileInfo(operationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TextBoxForm pathForm = new TextBoxForm();
            pathForm.ShowDialog();
            var result = TextBoxForm.path + "/" + currentlySelectedItemName;
            TextBoxForm.path = "";

            try
            {
                FileInfo.CopyTo(result, true);
                isFile = false;
                loadFilesAndDirectories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        #region Drive Context Menu
        private void openDrive_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void propertiesDrive_Click(object sender, EventArgs e)
        {
            propPath = drivePath;

            PropForm formm = new PropForm();
            formm.ShowDialog();
        }
        #endregion

        #region Folder Context Menu
        private DirectoryInfo DirectoryInfo { get; set; }
        private void openFolder_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void packFolder_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePathTextBox.Text;

            try
            {
                ZipFile.CreateFromDirectory(operationPath, operationPath + ".zip", CompressionLevel.Optimal, true);

                loadFilesAndDirectories();
                isFile = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void deleteFolder_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePathTextBox.Text;

            try
            {
                DirectoryInfo = new DirectoryInfo(operationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                var result = MessageBox.Show($"Вы действительно хотите удалить: {DirectoryInfo.Name}?",
                $"Подтвердите удаление файла", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2, 
                MessageBoxOptions.DefaultDesktopOnly); 

                if (result == DialogResult.Yes)
                {
                    DirectoryInfo.Delete(true);
                }
                loadFilesAndDirectories();
                isFile = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void copyFolder_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePathTextBox.Text;

            try
            {
                DirectoryInfo = new DirectoryInfo(operationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TextBoxForm pathForm = new TextBoxForm();
            pathForm.ShowDialog();
            var result = TextBoxForm.path + "/" + currentlySelectedItemName;

            try
            {
                DirectoryInfo.MoveTo(result);

                loadFilesAndDirectories();
                isFile = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TextBoxForm.path = "";


        }

        private void propertiesFolder_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePathTextBox.Text;

            propPath = operationPath;

            PropForm formm = new PropForm();
            formm.ShowDialog();
        }

        #endregion

        #region File Context Menu
        private FileInfo FileInfo { get; set; }
        private void openFile_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
        private void copyFile_Click(object sender, EventArgs e)
        {
            CopyFile();
        }
        private void propertiesFiles_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePath + "/" + currentlySelectedItemName;

            propPath = operationPath;

            PropForm formm = new PropForm();
            formm.ShowDialog();
        }
        #endregion

        #region Archive Context Menu
        private void openArchive_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }
        private void unpackArchive_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePath + "/" + currentlySelectedItemName;
            var extractionPath = operationPath.Remove(operationPath.LastIndexOf("."));
            try
            {
                ZipFile.ExtractToDirectory(operationPath, extractionPath);

                isFile = false;
                loadFilesAndDirectories();
                isFile = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void deleteArchive_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
        private void copyArchive_Click(object sender, EventArgs e)
        {
            CopyFile();
        }
        private void propertiesArchive_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            operationPath = filePath + "/" + currentlySelectedItemName;

            propPath = operationPath;

            PropForm formm = new PropForm();
            formm.ShowDialog();
        }


        #endregion

        #region FolderInside Context Menu
        private void fileCreateFolderInsideMenu_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            TextBoxForm pathForm = new TextBoxForm();

            pathForm.ShowDialog();
            var result = TextBoxForm.path;
            operationPath = filePath +"/" +result;
            TextBoxForm.path = "";

            try
            {
                FileInfo = new FileInfo(operationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (FileInfo.Exists)
            {
                MessageBox.Show($"Файл \"{FileInfo.FullName}\" уже существует");
            }

            try
            {
                FileInfo.Create();

                isFile = false;
                loadFilesAndDirectories();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void folderCreateFolderInsideMenu_Click(object sender, EventArgs e)
        {
            removeBackSlash();
            TextBoxForm pathForm = new TextBoxForm();

            pathForm.ShowDialog();
            var result = TextBoxForm.path;
            operationPath = filePath + "/" + result;
            TextBoxForm.path = "";

            if (Directory.Exists(operationPath))
            {
                MessageBox.Show($"Каталог \"{DirectoryInfo.FullName}\" уже существует");
            }

            try
            {
                DirectoryInfo = new DirectoryInfo(operationPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DirectoryInfo.Create();
                loadFilesAndDirectories();
                isFile = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        #endregion

    }
}
