#nullable enable
using ResourceLibrary;
using ResourceLibrary.Models;

namespace ChangeImageCore7a.Classes;

/// <summary>
/// Provides access to resource images by loading them once
/// </summary>
public sealed class ResourceImages
{
    private static readonly Lazy<ResourceImages> Lazy = new(() => new());

    public static ResourceImages Instance => Lazy.Value;

    private List<ResourceItem>? _images;
    /// <summary>
    /// Retrieves a list of all resource images, including icons and bitmaps, from the project resources.
    /// </summary>
    /// <remarks>
    /// This method loads the resource images using the resource manager and caches them for subsequent calls.
    /// </remarks>
    /// <returns>
    /// A <see cref="List{T}"/> of <see cref="ResourceItem"/> objects representing the resource images.
    /// </returns>
    public List<ResourceItem> Images()
    {
        _images = Properties.Resources.ResourceManager.ResourceItemList();
        return _images;
    }
}