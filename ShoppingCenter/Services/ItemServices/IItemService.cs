using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;

namespace ShoppingCenter.Services.ItemServices
{
    public interface IItemService
    {
        void Create(ItemVm itemVm,int id);
        void Update(ItemVm itemVm, int id);
        void Delete(int id);
        Item GetById(int id);
        //Task Create(ItemVm itemVm);
    }
}
