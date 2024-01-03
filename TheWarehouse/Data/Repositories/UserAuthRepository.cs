using Microsoft.AspNetCore.Authentication.OAuth;
using System.Text;
using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public class UserAuthRepository : IUserAuthRepository, IDisposable
    {
        private readonly WarehouseDbContext context;

        public UserAuthRepository(WarehouseDbContext context)
        {
            this.context = context;
        }

        public UserAuth CreateToken(int userId)
        {
            UserAuth NewAuth = new UserAuth { UserId = userId, AuthToken = GenerateRandomString(30), Expiry = DateTime.Now.AddDays(30) };
            context.UserAuths.Add(NewAuth);
            context.SaveChanges();
            return NewAuth;
        }

        public string GenerateRandomString(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb = new StringBuilder(length);
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(allowedChars.Length);
                sb.Append(allowedChars[index]);
            }

            return sb.ToString();
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
