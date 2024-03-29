﻿using ResourceLibrary;
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
    /// Get all icon and bitmap images from project resources
    /// </summary>
    /// <returns>list of images</returns>
    public List<ResourceItem> Images()
    {
        _images = ImageHelper.ResourceItemList(Properties.Resources.ResourceManager);
        return _images;
    }
}