using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models.ViewModels
{
    public class ItemVm
    {
        [Key]
        public int ItemId { get; set; }
        public string? NameItem { get; set; }
        public string? ColorItem { get; set; }
        public string? SizeItem { get; set; }
        public decimal PriceItem { get; set; }
        public string? Url { get; set; }
        public string? DescriptionItem { get; set; }

    }
}
