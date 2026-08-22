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
        AllImagesListBox = new ListBox();
        AllImagesPictureBox = new PictureBox();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        IconListBox = new ListBox();
        IconPictureBox = new PictureBox();
        tabPage3 = new TabPage();
        BitmapImagesListBox = new ListBox();
        BitmapPictureBox = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)AllImagesPictureBox).BeginInit();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)IconPictureBox).BeginInit();
        tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)BitmapPictureBox).BeginInit();
        SuspendLayout();
        // 
        // AllImagesListBox
        // 
        AllImagesListBox.FormattingEnabled = true;
        AllImagesListBox.Location = new Point(5, 11);
        AllImagesListBox.Margin = new Padding(3, 2, 3, 2);
        AllImagesListBox.Name = "AllImagesListBox";
        AllImagesListBox.Size = new Size(188, 154);
        AllImagesListBox.TabIndex = 1;
        // 
        // AllImagesPictureBox
        // 
        AllImagesPictureBox.Location = new Point(216, 11);
        AllImagesPictureBox.Margin = new Padding(3, 2, 3, 2);
        AllImagesPictureBox.Name = "AllImagesPictureBox";
        AllImagesPictureBox.Size = new Size(280, 153);
        AllImagesPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        AllImagesPictureBox.TabIndex = 2;
        AllImagesPictureBox.TabStop = false;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Margin = new Padding(3, 2, 3, 2);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(536, 205);
        tabControl1.TabIndex = 3;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(AllImagesListBox);
        tabPage1.Controls.Add(AllImagesPictureBox);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Margin = new Padding(3, 2, 3, 2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3, 2, 3, 2);
        tabPage1.Size = new Size(528, 177);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "All images";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(IconListBox);
        tabPage2.Controls.Add(IconPictureBox);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Margin = new Padding(3, 2, 3, 2);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3, 2, 3, 2);
        tabPage2.Size = new Size(528, 177);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Icon images";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // IconListBox
        // 
        IconListBox.FormattingEnabled = true;
        IconListBox.Location = new Point(7, 4);
        IconListBox.Margin = new Padding(3, 2, 3, 2);
        IconListBox.Name = "IconListBox";
        IconListBox.Size = new Size(188, 154);
        IconListBox.TabIndex = 7;
        // 
        // IconPictureBox
        // 
        IconPictureBox.Location = new Point(218, 4);
        IconPictureBox.Margin = new Padding(3, 2, 3, 2);
        IconPictureBox.Name = "IconPictureBox";
        IconPictureBox.Size = new Size(280, 153);
        IconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        IconPictureBox.TabIndex = 8;
        IconPictureBox.TabStop = false;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(BitmapImagesListBox);
        tabPage3.Controls.Add(BitmapPictureBox);
        tabPage3.Location = new Point(4, 24);
        tabPage3.Margin = new Padding(3, 2, 3, 2);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3, 2, 3, 2);
        tabPage3.Size = new Size(528, 177);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Bitmap images";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // BitmapImagesListBox
        // 
        BitmapImagesListBox.FormattingEnabled = true;
        BitmapImagesListBox.Location = new Point(19, 14);
        BitmapImagesListBox.Margin = new Padding(3, 2, 3, 2);
        BitmapImagesListBox.Name = "BitmapImagesListBox";
        BitmapImagesListBox.Size = new Size(188, 154);
        BitmapImagesListBox.TabIndex = 3;
        // 
        // BitmapPictureBox
        // 
        BitmapPictureBox.Location = new Point(230, 14);
        BitmapPictureBox.Margin = new Padding(3, 2, 3, 2);
        BitmapPictureBox.Name = "BitmapPictureBox";
        BitmapPictureBox.Size = new Size(280, 153);
        BitmapPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        BitmapPictureBox.TabIndex = 4;
        BitmapPictureBox.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(536, 205);
        Controls.Add(tabControl1);
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        ((System.ComponentModel.ISupportInitialize)AllImagesPictureBox).EndInit();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)IconPictureBox).EndInit();
        tabPage3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)BitmapPictureBox).EndInit();
        ResumeLayout(false);

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
