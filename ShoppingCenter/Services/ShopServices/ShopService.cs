using Microsoft.EntityFrameworkCore;
using ShoppingCenter.Areas.Identity.Data;
using ShoppingCenter.Models;

namespace ShoppingCenter.Services.ShopServices
{
    public class ShopService : IShopService
    {
        private readonly IdentityContext _context;

        public ShopService(IdentityContext context)
        {
            _context = context;
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

        public Shop GetItems(string id)
        {
            var items = _context.Shop.Include(x => x.Items).FirstOrDefault(x => x.ShopId.ToString() == id);
            return items;
        }
    }
}
