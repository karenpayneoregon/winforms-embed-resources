namespace ChangeImageCore7a;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.AllImagesListBox = new System.Windows.Forms.ListBox();
            this.AllImagesPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IconListBox = new System.Windows.Forms.ListBox();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BitmapImagesListBox = new System.Windows.Forms.ListBox();
            this.BitmapPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllImagesPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllImagesListBox
            // 
            this.AllImagesListBox.FormattingEnabled = true;
            this.AllImagesListBox.ItemHeight = 20;
            this.AllImagesListBox.Location = new System.Drawing.Point(6, 15);
            this.AllImagesListBox.Name = "AllImagesListBox";
            this.AllImagesListBox.Size = new System.Drawing.Size(214, 204);
            this.AllImagesListBox.TabIndex = 1;
            // 
            // AllImagesPictureBox
            // 
            this.AllImagesPictureBox.Location = new System.Drawing.Point(247, 15);
            this.AllImagesPictureBox.Name = "AllImagesPictureBox";
            this.AllImagesPictureBox.Size = new System.Drawing.Size(320, 204);
            this.AllImagesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AllImagesPictureBox.TabIndex = 2;
            this.AllImagesPictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 273);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AllImagesListBox);
            this.tabPage1.Controls.Add(this.AllImagesPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IconListBox);
            this.tabPage2.Controls.Add(this.IconPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Icon images";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IconListBox
            // 
            this.IconListBox.FormattingEnabled = true;
            this.IconListBox.ItemHeight = 20;
            this.IconListBox.Location = new System.Drawing.Point(8, 6);
            this.IconListBox.Name = "IconListBox";
            this.IconListBox.Size = new System.Drawing.Size(214, 204);
            this.IconListBox.TabIndex = 7;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Location = new System.Drawing.Point(249, 6);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(320, 204);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 8;
            this.IconPictureBox.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BitmapImagesListBox);
            this.tabPage3.Controls.Add(this.BitmapPictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(604, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bitmap images";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BitmapImagesListBox
            // 
            this.BitmapImagesListBox.FormattingEnabled = true;
            this.BitmapImagesListBox.ItemHeight = 20;
            this.BitmapImagesListBox.Location = new System.Drawing.Point(22, 18);
            this.BitmapImagesListBox.Name = "BitmapImagesListBox";
            this.BitmapImagesListBox.Size = new System.Drawing.Size(214, 204);
            this.BitmapImagesListBox.TabIndex = 3;
            // 
            // BitmapPictureBox
            // 
            this.BitmapPictureBox.Location = new System.Drawing.Point(263, 18);
            this.BitmapPictureBox.Name = "BitmapPictureBox";
            this.BitmapPictureBox.Size = new System.Drawing.Size(320, 204);
            this.BitmapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BitmapPictureBox.TabIndex = 4;
            this.BitmapPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 273);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            ((System.ComponentModel.ISupportInitialize)(this.AllImagesPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BitmapPictureBox)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private ListBox AllImagesListBox;
    private PictureBox AllImagesPictureBox;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private ListBox IconListBox;
    private PictureBox IconPictureBox;
    private TabPage tabPage3;
    private ListBox BitmapImagesListBox;
    private PictureBox BitmapPictureBox;
}
