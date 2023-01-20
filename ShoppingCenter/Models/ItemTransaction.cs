using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class ItemTransaction
    {
        public Guid ItemTransactionId { get; set; }
        public Guid TransactionId { get; set; }
        public Guid ItemId { get; set; }
        public Transaction? Transaction { get; set; }
        public Item? Item { get; set; }
        public decimal PriceItem { get; set; }
    }
}
