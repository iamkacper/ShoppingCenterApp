using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        //public string? UrlPicture { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [MinLength(6, ErrorMessage = "Store name should contain more than 6 words.")]
        
        public string? ShopName { get; set; }

        [Required(ErrorMessage ="Field is required")]
        [MinLength(10, ErrorMessage = "Describe the shop to the customer. Use more words.")]
        public string? Description { get; set; }

        [Required]
        [Url]
        public string? Url { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email for customer contact.")]
        public string? Email { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "Please provide a valid telephone number. ")]
        [Phone(ErrorMessage = "Provide a valid telephone number for customer contact.")]
        public string? Phone { get; set; }


        [Required(ErrorMessage = "Field is required")]
        [Range(0, 3, ErrorMessage = "The value should be in the range 0 to 3. Because Shopping Center has only 3 levels.")]
        public string? Level { get; set; }
        public List<Shop_Items>? Shop_Items { get; set; }
    }
}
