using ShoppingCenter.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid CustomerId { get; set; }
        public ShoppingCenterUser? Customer { get; set; }
        public List<ItemTransaction>? ItemsTransaction { get; set; }
    }
}
