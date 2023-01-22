using ChangeImageCore7a.Classes;
using ResourceLibrary.Models;

namespace ChangeImageCore7a;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new ();

    public Form1()
    {
        InitializeComponent();
        Shown += OnShown;
    }

    /// <summary>
    /// Get all images in this project resources to a <see cref="BindingSource"/> which
    /// allows changing the image in pictureBox1 when the selected item in the ListBox changes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnShown(object? sender, EventArgs e)
    {
        _bindingSource.DataSource = ResourceImages.Instance.Images().OrderBy(x => x.Name).ToList();
        AllImagesListBox.DataSource = _bindingSource;
        _bindingSource.PositionChanged += BindingSource_PositionChanged;
        ChangeFromAllImage();
    }

    private void BindingSource_PositionChanged(object? sender, EventArgs e)
    {
        ChangeFromAllImage();
    }

    /// <summary>
    /// Change image and set the SizeMode of the PictureBox dependent on image type
    /// </summary>
    private void ChangeFromAllImage()
    {
        if (AllImagesListBox.SelectedIndex <= -1) return;

        var item = (ResourceItem) _bindingSource.Current;
        pictureBox1.SizeMode = item!.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox1.Image = item.Image;
    }
}
