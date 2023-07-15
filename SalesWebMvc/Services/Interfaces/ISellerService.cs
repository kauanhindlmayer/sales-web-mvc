using SalesWebMvc.Models;

namespace SalesWebMvc.Services.Interfaces
{
    public interface ISellerService
    {
        List<Seller> FindAll();
        Seller FindById(int id);
        void Insert(Seller obj);
        void Remove(int id);
    }
}
