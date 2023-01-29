using Microsoft.EntityFrameworkCore;
using ShoppingCenter.Areas.Identity.Data;
using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;

namespace ShoppingCenter.Services.ShopServices
{
    public class ShopService : IShopService
    {
        private readonly IdentityContext _context;

        public ShopService(IdentityContext context)
        {
            _context = context;
        }

        public void Create(ShopVm shop)
        {
            Shop result = new Shop()
            {
                ShopId = shop.ShopId,
                Url =shop.Url,
                ShopName = shop.ShopName,
                Description = shop.Description,
                Email= shop.Email,
                Level = shop.Level
            };
            _context.Shop.Add(result);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shopToDelete = _context.Shop.FirstOrDefault(x => x.ShopId == id);
            if(shopToDelete == null)
            {
                return;
            }
            _context.Shop.Remove(shopToDelete);
            _context.SaveChanges();
        }

        public void Edit(Shop shop, string id)
        {
            _context.Update(shop);
            _context.SaveChanges();
        }

        public List<Shop> GetAll()
        {
            var result = _context.Shop.ToList();
            return result;
        }

        public Shop GetById(string id)
        {
            var shop = _context.Shop.FirstOrDefault(x => x.ShopId.ToString() == id);

            if (shop == null)
            {
                return null;
            }
            return shop;
        }

        public Shop GetItems(int id)
        {
            var items = _context.Shop.Include(x => x.Shop_Items).ThenInclude(x => x.Item).FirstOrDefault(x => x.ShopId == id);
            return items;
        }
    }
}
