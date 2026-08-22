using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Resources;
using ResourceLibrary.Models;

namespace ResourceLibrary;

public class ImageHelper
{
    /// <summary>
    /// Retrieves the names of all resources in the specified <see cref="ResourceManager"/> 
    /// that are of type <see cref="Image"/> or <see cref="Icon"/>.
    /// </summary>
    /// <param name="manager">The <see cref="ResourceManager"/> instance to search for resources.</param>
    /// <returns>A list of resource names that correspond to <see cref="Image"/> or <see cref="Icon"/> objects.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="manager"/> is <c>null</c>.</exception>
    /// <remarks>
    /// This method filters resources to include only those that are either <see cref="Image"/> or <see cref="Icon"/>.
    /// The resource names are returned as strings.
    /// </remarks>
    public static List<string> ResourceImageNames(ResourceManager manager)
    {

        var names = new List<string>();
        var resourceSet = manager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

        names.AddRange(resourceSet!.Cast<DictionaryEntry>()
            .Where(dictionaryEntry => dictionaryEntry.Value is Image || 
                                      dictionaryEntry.Value is Icon)
            .Select(dictionaryEntry => dictionaryEntry.Key.ToString()));

        return names;
    }


    /// <summary>
    /// Retrieves a list of <see cref="ResourceItem"/> objects representing all bitmap and icon resources
    /// from the specified <see cref="ResourceManager"/>.
    /// </summary>
    /// <param name="manager">The <see cref="ResourceManager"/> instance to search for resources.</param>
    /// <returns>A list of <see cref="ResourceItem"/> objects containing metadata and content for each resource.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="manager"/> is <c>null</c>.</exception>
    /// <remarks>
    /// This method utilizes <see cref="ResourceImageNames(ResourceManager)"/> to identify resource names
    /// and then constructs <see cref="ResourceItem"/> objects for each resource.
    /// Bitmap resources are directly assigned to the <see cref="ResourceItem.Image"/> property.
    /// Icon resources are converted to bitmaps before assignment, and the <see cref="ResourceItem.IsIcon"/> property
    /// is set to <c>true</c>.
    /// </remarks>
    public static List<ResourceItem> ResourceItemList(ResourceManager manager)
    {
        var items = new List<ResourceItem>();

        foreach (var name in ResourceImageNames(manager))
        {

            var item = new ResourceItem()
            {
                Name = name, 
                IsIcon = false
            };

            if (manager!.GetObject(name) is Icon)
            {
                item.Image = ((Icon)manager.GetObject(name)!)?.ToBitmap();
                item.IsIcon = true;
            }
            else
            {
                item.Image = (Bitmap)manager.GetObject(name)!;
            }

            items.Add(item);


        }

        return items;

    }
}
