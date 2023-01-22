using System.ComponentModel;
using ChangeImageCore7a.Classes;
using ResourceLibrary.Extensions;
using ResourceLibrary.Models;

namespace ChangeImageCore7a;

public partial class Form1 : Form
{
    private readonly BindingSource _allBindingSource = new ();
    private readonly BindingSource _iconBindingSource = new ();
    private readonly BindingSource _bitmapBindingSource = new ();
    private BindingList<ResourceItem> _bindingList = new();

    public Form1()
    {
        InitializeComponent();
        Shown += OnShown;
    }


    private void OnShown(object? sender, EventArgs e)
    {

        _allBindingSource.DataSource = ResourceImages.Instance.Images().OrderBy(x => x.Name).ToList();
        AllImagesListBox.DataSource = _allBindingSource;
        _allBindingSource.PositionChanged += AllBindingSource_PositionChanged;

        ChangeFromAllImage();

        _iconBindingSource.DataSource = ResourceImages.Instance.Images().Icons().OrderBy(x => x.Name).ToList();
        IconListBox.DataSource = _iconBindingSource;
        _iconBindingSource.PositionChanged += IconBindingSource_PositionChanged;

        ChangeFromIconImage();

        _bindingList = new BindingList<ResourceItem>(ResourceImages.Instance.Images().BitMaps().OrderBy(x => x.Name).ToList());
        _bitmapBindingSource.DataSource = _bindingList;
        BitmapImagesListBox.DataSource = _bitmapBindingSource;
        _bitmapBindingSource.PositionChanged += BitmapBindingSource_PositionChanged;

        /*
         * Let's select a specific image
         * We use a BindingList as the BindingSource does not support the Find method
         */
        var resourceItem =_bindingList.FirstOrDefault(x => x.Name == "ready");
        if (resourceItem != null) _bitmapBindingSource.Position = _bitmapBindingSource.IndexOf(resourceItem);

        ChangeFromBitmapImage();

    }

    private void BitmapBindingSource_PositionChanged(object? sender, EventArgs e)
    {
        ChangeFromBitmapImage();
    }

    private void IconBindingSource_PositionChanged(object? sender, EventArgs e)
    {
        ChangeFromIconImage();
    }

    private void AllBindingSource_PositionChanged(object? sender, EventArgs e)
    {
        ChangeFromAllImage();
    }

    /// <summary>
    /// Change image and set the SizeMode of the PictureBox dependent on image type
    /// </summary>
    private void ChangeFromAllImage()
    {
        if (AllImagesListBox.SelectedIndex <= -1) return;

        var item = (ResourceItem) _allBindingSource.Current;
        pictureBox1.SizeMode = item!.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox1.Image = item.Image;
    }

    private void ChangeFromIconImage()
    {
        if (IconListBox.SelectedIndex <= -1) return;

        var item = (ResourceItem)_iconBindingSource.Current;
        pictureBox2.SizeMode = item!.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox2.Image = item.Image;
    }
    private void ChangeFromBitmapImage()
    {
        if (BitmapImagesListBox.SelectedIndex <= -1) return;

        var item = (ResourceItem)_bitmapBindingSource.Current;
        pictureBox3.SizeMode = item!.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox3.Image = item.Image;
    }
}