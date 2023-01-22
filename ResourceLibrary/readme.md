# About

Provides methods to get images from a calling windows forms project.

For the calling Windows Form project

- Added resources, Icons, Bitmaps
- Load images using `ResourceImages.Instance.Images()` and optionally use OrderBy to sort by resource name
- The following model
    - IsIcon indicates an image is an Icon or BitMap
    - ToString overrides provides DisplayMember for a controls like a ComboBox or ListBox.

```csharp
public class ResourceItem
{
    /// <summary>
    /// Resource name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Image which is either an <see cref="Icon"/> or <see cref="Bitmap"/>
    /// </summary>
    public Bitmap Image { get; set; }
    /// <summary>
    /// Indicates if dealing with an icon so when displaying the
    /// control used to display can adjust it's size or Size mode
    /// </summary>
    public bool IsIcon { get; set; }
    public override string ToString() => Name;
}
```

- The following language extension method allow obtaining only icons or bitmaps

```csharp
public static class ResourceItemExtensions
{
    /// <summary>
    /// Return resources of type Icon
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>list of icons or an empty list</returns>
    public static List<ResourceItem> Icons(this List<ResourceItem> sender) 
        => sender.Where(item => item.IsIcon).ToList();

    /// <summary>
    /// Return resources of type Bitmap
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>list of bitmaps or an empty list</returns>        
    public static List<ResourceItem> BitMaps(this List<ResourceItem> sender) 
        => sender.Where(item => !item.IsIcon).ToList();
}
```
