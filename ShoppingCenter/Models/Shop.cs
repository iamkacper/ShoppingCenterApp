using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        public ISet<ShopCategory>? Categories { get; set; }
        //public string? UrlPicture { get; set; }
        public string? ShopName { get; set; }
        public string? Description { get; set; }
        public string? Level { get; set; }
        public List<Shop_Items>? Shop_Items { get; set; }
    }
}
