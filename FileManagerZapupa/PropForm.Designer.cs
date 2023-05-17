
namespace FileManagerZapupa
{
    partial class PropForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropForm));
            this.typeLabel = new System.Windows.Forms.Label();
            this.fileIcon = new System.Windows.Forms.PictureBox();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.locationLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.creTLabel = new System.Windows.Forms.Label();
            this.lastWTLabel = new System.Windows.Forms.Label();
            this.lastATLabel = new System.Windows.Forms.Label();
            this.containsLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.occupiedPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeLabel.Location = new System.Drawing.Point(121, 88);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(36, 15);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type:";
            // 
            // fileIcon
            // 
            this.fileIcon.Location = new System.Drawing.Point(12, 25);
            this.fileIcon.Name = "fileIcon";
            this.fileIcon.Size = new System.Drawing.Size(35, 35);
            this.fileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileIcon.TabIndex = 1;
            this.fileIcon.TabStop = false;
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
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.locationLabel.Location = new System.Drawing.Point(121, 109);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(57, 15);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sizeLabel.Location = new System.Drawing.Point(121, 130);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(34, 15);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Size:";
            // 
            // creTLabel
            // 
            this.creTLabel.AutoSize = true;
            this.creTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.creTLabel.Location = new System.Drawing.Point(121, 174);
            this.creTLabel.Name = "creTLabel";
            this.creTLabel.Size = new System.Drawing.Size(87, 15);
            this.creTLabel.TabIndex = 0;
            this.creTLabel.Text = "Creation Time:";
            // 
            // lastWTLabel
            // 
            this.lastWTLabel.AutoSize = true;
            this.lastWTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lastWTLabel.Location = new System.Drawing.Point(121, 197);
            this.lastWTLabel.Name = "lastWTLabel";
            this.lastWTLabel.Size = new System.Drawing.Size(92, 15);
            this.lastWTLabel.TabIndex = 0;
            this.lastWTLabel.Text = "Last Write Time";
            // 
            // lastATLabel
            // 
            this.lastATLabel.AutoSize = true;
            this.lastATLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lastATLabel.Location = new System.Drawing.Point(121, 222);
            this.lastATLabel.Name = "lastATLabel";
            this.lastATLabel.Size = new System.Drawing.Size(99, 15);
            this.lastATLabel.TabIndex = 0;
            this.lastATLabel.Text = "Last Acess Time:";
            // 
            // containsLabel
            // 
            this.containsLabel.AutoSize = true;
            this.containsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.containsLabel.Location = new System.Drawing.Point(121, 152);
            this.containsLabel.Name = "containsLabel";
            this.containsLabel.Size = new System.Drawing.Size(58, 15);
            this.containsLabel.TabIndex = 0;
            this.containsLabel.Text = "Contains:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(227, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Ok";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contains:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Creation Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Last Write Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Last Acess Time:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(277, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(120, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Occcupied Space";
            this.label1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Free Space";
            this.label9.Visible = false;
            // 
            // occupiedPercent
            // 
            this.occupiedPercent.AutoSize = true;
            this.occupiedPercent.Location = new System.Drawing.Point(260, 242);
            this.occupiedPercent.Name = "occupiedPercent";
            this.occupiedPercent.Size = new System.Drawing.Size(33, 13);
            this.occupiedPercent.TabIndex = 5;
            this.occupiedPercent.Text = "932%";
            this.occupiedPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.occupiedPercent.Visible = false;
            // 
            // PropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 333);
            this.Controls.Add(this.occupiedPercent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.fileIcon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastATLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastWTLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.creTLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.containsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropForm";
            this.Text = "PropForm";
            this.Load += new System.EventHandler(this.PropForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.PictureBox fileIcon;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label creTLabel;
        private System.Windows.Forms.Label lastWTLabel;
        private System.Windows.Forms.Label lastATLabel;
        private System.Windows.Forms.Label containsLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label occupiedPercent;
    }
}