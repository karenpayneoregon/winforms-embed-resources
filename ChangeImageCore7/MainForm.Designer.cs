
namespace ChangeImageCore7
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            AllImagesListBox = new ListBox();
            SelectFromAllImagesButton = new Button();
            label1 = new Label();
            IconListBox = new ListBox();
            label2 = new Label();
            BitmapListBox = new ListBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AllImagesListBox
            // 
            AllImagesListBox.FormattingEnabled = true;
            AllImagesListBox.Location = new Point(20, 51);
            AllImagesListBox.Name = "AllImagesListBox";
            AllImagesListBox.Size = new Size(185, 154);
            AllImagesListBox.TabIndex = 2;
            // 
            // SelectFromAllImagesButton
            // 
            SelectFromAllImagesButton.Location = new Point(139, 26);
            SelectFromAllImagesButton.Name = "SelectFromAllImagesButton";
            SelectFromAllImagesButton.Size = new Size(66, 23);
            SelectFromAllImagesButton.TabIndex = 3;
            SelectFromAllImagesButton.Text = "Select";
            SelectFromAllImagesButton.UseVisualStyleBackColor = true;
            SelectFromAllImagesButton.Click += SelectFromAllImagesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 5;
            label1.Text = "Icons and Bitmaps";
            // 
            // IconListBox
            // 
            IconListBox.FormattingEnabled = true;
            IconListBox.Location = new Point(12, 272);
            IconListBox.Name = "IconListBox";
            IconListBox.Size = new Size(185, 94);
            IconListBox.Sorted = true;
            IconListBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 251);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Icons only";
            // 
            // BitmapListBox
            // 
            BitmapListBox.FormattingEnabled = true;
            BitmapListBox.Location = new Point(370, 271);
            BitmapListBox.Name = "BitmapListBox";
            BitmapListBox.Size = new Size(185, 94);
            BitmapListBox.Sorted = true;
            BitmapListBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 251);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 9;
            label3.Text = "Bitmaps only";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SelectFromAllImagesButton);
            groupBox1.Controls.Add(AllImagesListBox);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 226);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 387);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(BitmapListBox);
            Controls.Add(label2);
            Controls.Add(IconListBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code sample";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox AllImagesListBox;
        private System.Windows.Forms.Button SelectFromAllImagesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IconListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox BitmapListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}