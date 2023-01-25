using ShoppingCenter.Models;

namespace ShoppingCenter.Services.ShopServices
{
    public interface IShopService
    {
        List<Shop> GetAll();
        Shop GetById(string id);
        void Edit(Shop shop, string id);
        Shop GetItems(int id);
    }
}
