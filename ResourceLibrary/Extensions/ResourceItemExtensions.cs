using ResourceLibrary.Models;

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
            => [.. sender.Where(item => !item.IsIcon)];
    }
}