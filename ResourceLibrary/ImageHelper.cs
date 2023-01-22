using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Resources;
using ResourceLibrary.Models;

namespace ResourceLibrary;

public class ImageHelper
{
    public static List<string> ResourceImageNames(ResourceManager manager)
    {

        var names = new List<string>();
        var resourceSet = manager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

        names.AddRange(
            from DictionaryEntry dictionaryEntry in resourceSet
            where dictionaryEntry.Value is Image || dictionaryEntry.Value is Icon
            select dictionaryEntry.Key.ToString());

        return names;
    }


    /// <summary>
    /// Get all bitmap and icon resources
    /// </summary>
    /// <returns></returns>
    public static List<ResourceItem> ResourceItemList(ResourceManager? manager)
    {
        var items = new List<ResourceItem>();

        foreach (var name in ResourceImageNames(manager))
        {

            var item = new ResourceItem() { Name = name, IsIcon = false };

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
