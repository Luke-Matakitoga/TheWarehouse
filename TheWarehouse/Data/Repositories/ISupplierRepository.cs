using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public interface ISupplierRepository : IDisposable
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplierById(int? supplierId);
        Task InsertSupplier(Supplier supplier);
        void DeleteSupplier(int? supplierId);
        void UpdateSupplier(Supplier supplier);
        Task Save();
    }
}
