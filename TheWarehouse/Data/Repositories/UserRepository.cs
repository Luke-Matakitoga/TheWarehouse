using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public class UserRepository : IUserRepository, IDisposable
    {
        public WarehouseDbContext context;

        public UserRepository(WarehouseDbContext context)
        {
            this.context = context;
        }

        public int Login(string? email, string? password)
        {
            User user = context.Users.FirstOrDefault(u => u.Email == email);
            if (user!=null){
                if(user.Password == password)
                {
                    return 1; // Success
                }
                else
                {
                    return -2; // Password incorrect
                }
            }
            else
            {
                return -1; // User not found
            }
        }

        public int GetUserId(string? email)
        {
            User user = context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                return user.Id;
            }
            else
            {
                return -1; // User not found
            }
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
