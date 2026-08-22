using System.Collections;
using System.Globalization;
using ChangeImageCore7.Properties;

namespace ChangeImageCore7.Classes;

/// <summary>
/// Read images from current project resources
/// </summary>
public class ImageHelper
{

    /// <summary>
    /// Retrieves a list of resource items containing all bitmap and icon resources 
    /// from the current project's resources, excluding specific entries like "ready".
    /// </summary>
    /// <returns>
    /// A list of <see cref="ResourceItem"/> objects, each representing a bitmap or icon resource.
    /// </returns>
    /// <remarks>
    /// This method iterates through all resource names obtained from <see cref="ResourceImageNames"/> 
    /// and creates a <see cref="ResourceItem"/> for each valid resource. 
    /// If the resource is an icon, it is converted to a bitmap and marked as such.
    /// </remarks>
    /// <exception cref="InvalidCastException">
    /// Thrown if a resource cannot be cast to <see cref="Bitmap"/> or <see cref="Icon"/>.
    /// </exception>
    public static List<ResourceItem> ResourceItemList()
    {
        var items = new List<ResourceItem>();

        foreach (var name in ResourceImageNames())
        {

            if (name == "ready")
                continue;
                
            var item = new ResourceItem() {Name = name, IsIcon = false};
                
            if (Resources.ResourceManager.GetObject(name) is Icon)
            {
                item.Image  = ((Icon)Resources.ResourceManager.GetObject(name))?.ToBitmap();
                item.IsIcon = true;
            }
            else
            {
                item.Image = (Bitmap)Resources.ResourceManager.GetObject(name);
            }
                
            items.Add(item);


        }

        return items;
            
    }

    /// <summary>
    /// Get all resource names for icon and bitmaps
    /// </summary>
    /// <returns></returns>
    public static List<string> ResourceImageNames()
    {

        try
        {
                
            var names = new List<string>();
                
            var resourceSet = Resources
                .ResourceManager
                .GetResourceSet(CultureInfo.CurrentUICulture, true, true);


            names.AddRange(
                from DictionaryEntry dictionaryEntry in resourceSet 
                where dictionaryEntry.Value is Image or Icon 
                select dictionaryEntry.Key.ToString());
                
            return names;
                
        }
        catch (Exception)
        {
            return null;
        }
    }
}