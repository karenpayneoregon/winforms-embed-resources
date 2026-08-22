using ChangeImageCore7.Classes;

namespace ChangeImageCore7.Extensions;

public static class ResourceItemExtensions
{
    /// <param name="sender"></param>
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
    }
}