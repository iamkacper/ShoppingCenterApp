using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;

namespace ShoppingCenter.Services.ItemServices
{
    public interface IItemService
    {
        void Create(ItemVm itemVm, int id);
        bool Update(ItemVm itemVm, int id);
        bool Delete(int id);
        Item GetById(int id);
        //Task Create(ItemVm itemVm);
    }
}
