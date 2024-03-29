﻿
namespace ChangeImage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AllImagesListBox = new System.Windows.Forms.ListBox();
            this.SelectFromAllImagesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IconListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BitmapListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AllImagesListBox
            // 
            this.AllImagesListBox.FormattingEnabled = true;
            this.AllImagesListBox.ItemHeight = 20;
            this.AllImagesListBox.Location = new System.Drawing.Point(23, 68);
            this.AllImagesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllImagesListBox.Name = "AllImagesListBox";
            this.AllImagesListBox.Size = new System.Drawing.Size(211, 204);
            this.AllImagesListBox.TabIndex = 2;
            // 
            // SelectFromAllImagesButton
            // 
            this.SelectFromAllImagesButton.Location = new System.Drawing.Point(159, 33);
            this.SelectFromAllImagesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectFromAllImagesButton.Name = "SelectFromAllImagesButton";
            this.SelectFromAllImagesButton.Size = new System.Drawing.Size(76, 31);
            this.SelectFromAllImagesButton.TabIndex = 3;
            this.SelectFromAllImagesButton.Text = "Select";
            this.SelectFromAllImagesButton.UseVisualStyleBackColor = true;
            this.SelectFromAllImagesButton.Click += new System.EventHandler(this.SelectFromAllImagesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Icons and Bitmaps";
            // 
            // IconListBox
            // 
            this.IconListBox.FormattingEnabled = true;
            this.IconListBox.ItemHeight = 20;
            this.IconListBox.Location = new System.Drawing.Point(14, 363);
            this.IconListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconListBox.Name = "IconListBox";
            this.IconListBox.Size = new System.Drawing.Size(211, 124);
            this.IconListBox.Sorted = true;
            this.IconListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Icons only";
            // 
            // BitmapListBox
            // 
            this.BitmapListBox.FormattingEnabled = true;
            this.BitmapListBox.ItemHeight = 20;
            this.BitmapListBox.Location = new System.Drawing.Point(423, 361);
            this.BitmapListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BitmapListBox.Name = "BitmapListBox";
            this.BitmapListBox.Size = new System.Drawing.Size(211, 124);
            this.BitmapListBox.Sorted = true;
            this.BitmapListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitmaps only";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectFromAllImagesButton);
            this.groupBox1.Controls.Add(this.AllImagesListBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(619, 301);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitmapListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IconListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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