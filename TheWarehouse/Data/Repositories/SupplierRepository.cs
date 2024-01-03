using Microsoft.EntityFrameworkCore;
using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public class SupplierRepository : ISupplierRepository, IDisposable
    {
        private WarehouseDbContext context;

        public SupplierRepository(WarehouseDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await context.Suppliers.ToListAsync();
        }
        public async Task<Supplier> GetSupplierById(int? supplierId)
        {
            return await context.Suppliers.FindAsync(supplierId);
        }
        public async Task InsertSupplier(Supplier supplier)
        {
            await context.Suppliers.AddAsync(supplier);
        }
        public void DeleteSupplier(int? supplierId)
        {
            context.Suppliers.Remove(context.Suppliers.Find(supplierId));
        }
        public void UpdateSupplier(Supplier supplier)
        {
            context.Suppliers.Update(supplier);
            context.Entry(supplier).State = EntityState.Modified;
        }
        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
