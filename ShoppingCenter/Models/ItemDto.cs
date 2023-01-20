using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCenter.Models
{
    public class ItemDto
    {
        public ItemDto() { }
        public ItemDto(Item item)
        {
            ItemId = item.ItemId.ToString();
            NameItem = item.NameItem;
            AvailabilityItem = item.AvailabilityItem;
            ColorItem = item.ColorItem;
            PriceItem = item.PriceItem;
            DescriptionItem = item.DescriptionItem;
        }

        [HiddenInput]
        public string? ItemId { get; set; }
        public string? NameItem { get; set; }
        public int AvailabilityItem { get; set; }
        public string? ColorItem { get; set; }
        public decimal PriceItem { get; set; }
        public string? DescriptionItem { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public List<string>? Categories { get; set; }
        public Item ConvertTo() => new Item()
        {
            ItemId = Guid.NewGuid(),
            NameItem = this.NameItem,
            PriceItem = this.PriceItem,
            ColorItem = this.ColorItem,
            AvailabilityItem = this.AvailabilityItem,
            DescriptionItem = this.DescriptionItem,
            Categories = (ISet<ItemCategory>)AssignCategories(Categories)
        };

        [ValidateNever]
        public List<SelectListItem>? listCategories { get; set; }

        private ISet<ItemCategory> AssignCategories(List<string>? ids)
        {
            HashSet<ItemCategory> categories = new HashSet<ItemCategory>();
            if (ids is not null)
                foreach (var item in ids)
                    categories.Add(new ItemCategory() { ItemCategoryId = Guid.Parse(item) });
            return categories;
        }
    }
}