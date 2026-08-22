using System.Drawing;
using ResourceLibrary.Models;
#pragma warning disable CA1416

namespace ResourceLibrary.Extensions;

public static class ResourceItemExtensions
{
    /// <summary>
    /// Provides extension methods for a list of <see cref="ResourceLibrary.Models.ResourceItem"/>.
    /// </summary>
    /// <param name="sender">The list of <see cref="ResourceLibrary.Models.ResourceItem"/> to extend.</param>
    extension(List<ResourceItem> sender)
    {
        /// <summary>
        /// Return resources of type Icon
        /// </summary>
        /// <returns>list of icons or an empty list</returns>
        public List<ResourceItem> Icons() 
            => sender.Where(item => item.IsIcon).ToList();

        /// <summary>
        /// Return resources of type Bitmap
        /// </summary>
        /// <returns>list of bitmaps or an empty list</returns>        
        public List<ResourceItem> BitMaps() 
            => sender.Where(item => !item.IsIcon).ToList();

        /// <summary>
        /// Retrieves an <see cref="System.Drawing.Icon"/> from the list of <see cref="ResourceLibrary.Models.ResourceItem"/> 
        /// by matching the specified name.
        /// </summary>
        /// <param name="name">The name of the resource to search for.</param>
        /// <returns>
        /// An <see cref="System.Drawing.Icon"/> if a matching resource with the specified name exists and is of type Icon; 
        /// otherwise, <c>null</c>.
        /// </returns>
        public Icon GetIconByName(string name)
        {
            var resourceItem = sender.FirstOrDefault(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && item.IsIcon);
            return resourceItem != null ? Icon.FromHandle(resourceItem.Image.GetHicon()) : null;
        }

        /// <summary>
        /// Retrieves a <see cref="System.Drawing.Bitmap"/> from the list of <see cref="ResourceLibrary.Models.ResourceItem"/> 
        /// by matching the specified name.
        /// </summary>
        /// <param name="name">The name of the resource to search for.</param>
        /// <returns>
        /// A <see cref="System.Drawing.Bitmap"/> if a matching resource with the specified name exists and is not of type Icon; 
        /// otherwise, <c>null</c>.
        /// </returns>
        public Bitmap GetBitmapByName(string name)
        {
            var resourceItem = sender.FirstOrDefault(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && !item.IsIcon);
            return resourceItem?.Image;
        }
    }
}