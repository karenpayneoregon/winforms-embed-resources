namespace ChangeImageCore7.Classes;

public class ResourceItem
{
    private Bitmap _image;
    private bool _isIcon;

    public string Name { get; set; }

    public Bitmap Image
    {
        get => _image;
        set
        {
            _image = value;
            SetIcon();
        }
    }

    public bool IsIcon
    {
        get => _isIcon;
        set
        {
            _isIcon = value;
            SetIcon();
        }
    }

    public Icon Icon { get; private set; }

    private void SetIcon()
    {
        Icon?.Dispose();
        Icon = null;

        if (_isIcon && _image is not null)
        {
            Icon = Icon.FromHandle(_image.GetHicon());
        }
    }

    public override string ToString() => Name;
}