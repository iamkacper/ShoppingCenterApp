using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace ShoppingCenter.Models.ViewModels
{
    public class ShopVm
    {
        public int ShopId { get; set; }
        public string? Url { get; set; }
        public string? ShopName { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Level { get; set; }
    }
}
