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

        public void Create(ItemVm itemVm,int id)
        {
            var item = new Item()
            {
                ItemId = itemVm.ItemId,
                NameItem = itemVm.NameItem,
                ColorItem = itemVm.ColorItem,
                SizeItem = itemVm.SizeItem,
                PriceItem = itemVm.PriceItem,
                Url = itemVm.Url,
                DescriptionItem = itemVm.DescriptionItem,
                Shop_Items= new List<Shop_Items>()
                {
                   new Shop_Items()
                   {
                    ShopId=id,
                    ItemId = itemVm.ItemId
                   }
                }
            };
            _context.Items.Add(item);
            _context.SaveChanges(); 

        }

        public void Delete(int id)
        {
            var item = _context.Items.FirstOrDefault(x => x.ItemId == id);
            _context.Items.Remove(item);
            _context.SaveChanges();
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

        public void Update(ItemVm itemVm, int id)
        {
            var foundItem = _context.Items.FirstOrDefault(x => x.ItemId == id);
            if (foundItem != null)
            {
                foundItem.NameItem= itemVm.NameItem;
                foundItem.ColorItem= itemVm.ColorItem;
                foundItem.SizeItem= itemVm.SizeItem;
                foundItem.PriceItem= itemVm.PriceItem;
                foundItem.Url = itemVm.Url;
                foundItem.DescriptionItem= itemVm.DescriptionItem;
            }
            _context.SaveChanges();

        }
    }
}
