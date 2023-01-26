using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;

namespace ShoppingCenter.Services.ShopServices
{
    public interface IShopService
    {
        List<Shop> GetAll();
        Shop GetById(string id);
        void Edit(Shop shop, string id);
        void Create(ShopVm shop);
        Shop GetItems(int id);
        void Delete(int id);
    }
}
