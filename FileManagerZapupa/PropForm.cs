using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileManagerZapupa
{
    public partial class PropForm : Form
    {
        public PropForm()
        {
            InitializeComponent();
        }

        private void PropForm_Load(object sender, EventArgs e)
        {
            if (Form1.root)
            {
                DriveProp();
            }
            else if (Form1.isFile)
            {
                FileProp();
            }
            else
            {
                FolderProp();
            }


        }
        private void DriveProp()
        {
            label7.Visible = false;
            label8.Visible = false;
            lastATLabel.Visible = false;
            lastWTLabel.Visible = false;
            progressBar1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label1.Visible = true;
            label9.Visible = true;
            occupiedPercent.Visible = true;

            fileIcon.Image = iconList.Images[11];
            label3.Text = "Drive Format:";
            label4.Text = "Occupied Space:";
            label5.Text = "Free Space:";
            label6.Text = "Total Size:";

            var drive = new DriveInfo(Form1.propPath);

            this.Text = $"Properties: {drive.Name}";
            var ocSpace = Convert.ToDouble(drive.TotalSize - drive.AvailableFreeSpace);
            var ocSpaceValue = ocSpace / Convert.ToDouble(drive.TotalSize);
            progressBar1.Value = Convert.ToInt32(ocSpaceValue * 100);

            typeLabel.Text = drive.DriveType.ToString();
            locationLabel.Text = drive.DriveFormat.ToString();
            sizeLabel.Text = ocSpace + " Bytes";
            containsLabel.Text = drive.TotalFreeSpace.ToString() + " Bytes";
            creTLabel.Text = drive.TotalSize.ToString() + " Bytes";
            occupiedPercent.Text = $"{ocSpaceValue * 100:f0} %";
        }
        private void FolderProp()
        {
            long folderSize = 0;
            int fileCount = 0, directoryCount = 0;
            label7.Visible = false;
            label8.Visible = false;
            lastATLabel.Visible = false;
            lastWTLabel.Visible = false;

            var folder = new DirectoryInfo(Form1.propPath);

            this.Text = $"Properties: {folder.Name}";

            fileIcon.Image = iconList.Images[10];
         
            typeLabel.Text = "Folder";
            locationLabel.Text = Form1.propPath;

            FileInfo[] files = folder.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                folderSize += file.Length;
                fileCount++;
            }
            sizeLabel.Text = $"{folderSize} Bytes";

            DirectoryInfo[] directories = folder.GetDirectories("*", SearchOption.AllDirectories);
            foreach (DirectoryInfo directory in directories)
            {
                directoryCount++;
            }
            containsLabel.Text = $"Files: {fileCount}; Folders: {directoryCount}";

            creTLabel.Text = folder.CreationTime.ToString();

        }
        private void FileProp()
        {
            label5.Visible = false;
            containsLabel.Visible = false;

            var file = new FileInfo(Form1.propPath);

            this.Text = $"Properties: {file.Name}";

            var fileExtension = file.Extension.ToUpper();

            switch (fileExtension)
            {
                case ".MP3":
                    fileIcon.Image = iconList.Images[5];
                    break;

                case ".EXE":
                    fileIcon.Image = iconList.Images[7];
                    break;

                case ".MP4":
                case ".AVI":
                case ".MKV":
                    fileIcon.Image = iconList.Images[6];
                    break;

                case ".PDF":
                    fileIcon.Image = iconList.Images[4];
                    break;

                case ".DOC":
                case ".DOCX":
                    fileIcon.Image = iconList.Images[3];
                    break;

                case ".PNG":
                case ".JPG":
                case ".JPEG":
                    fileIcon.Image = iconList.Images[9];
                    break;

                default:
                    fileIcon.Image = iconList.Images[8];
                    break;
            }

            typeLabel.Text = file.Extension.ToString();
            locationLabel.Text = Form1.propPath;
            sizeLabel.Text = $"{file.Length} Bytes";
            creTLabel.Text = file.CreationTime.ToString();
            lastWTLabel.Text = file.LastWriteTime.ToString();
            lastATLabel.Text = file.LastAccessTime.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
