using ShoppingCenter.Areas.Identity.Data;
using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;

namespace ShoppingCenter.Services.ItemServices
{
    public class ItemService : IItemService
    {
        private readonly IdentityContext _context;

        public ItemService(IdentityContext context)
        {
            _context = context;
        }

        public void Create(ItemVm itemVm, int id)
        {
            var item = new Item()
            {
                NameItem = itemVm.NameItem,
                ColorItem = itemVm.ColorItem,
                SizeItem = itemVm.SizeItem,
                PriceItem = itemVm.PriceItem,
                Url = itemVm.Url,
                DescriptionItem = itemVm.DescriptionItem
            };
            _context.Items.Add(item);
            _context.SaveChanges();

            var temp = new Shop_Items()
            {
                ShopId = id,
                ItemId = item.ItemId
            };

            _context.Shop_Items.Add(temp);
            _context.SaveChanges();

        }

        public bool Delete(int id)
        {
            var item = _context.Items.FirstOrDefault(x => x.ItemId == id);
            if (item == null)
            {
                return false;
            }
            _context.Items.Remove(item);
            _context.SaveChanges();
            return true;
        }

        public Item GetById(int id)
        {
            var item = _context.Items.FirstOrDefault(x => x.ItemId == id);
            if(item == null)
            {
                return null;
            }
            return item;
        }

        public bool Update(ItemVm itemVm, int id)
        {
            var foundItem = _context.Items.FirstOrDefault(x => x.ItemId == id);
            if(foundItem == null)
            {
                return false; 
            }
            foundItem.NameItem = itemVm.NameItem;
            foundItem.ColorItem = itemVm.ColorItem;
            foundItem.SizeItem = itemVm.SizeItem;
            foundItem.PriceItem = itemVm.PriceItem;
            foundItem.Url = itemVm.Url;
            foundItem.DescriptionItem = itemVm.DescriptionItem;

            _context.SaveChanges();
            return true;

        }
    }
}
