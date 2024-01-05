using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public interface IUserRepository : IDisposable
    {
        int Login(string? username, string? password);
        int GetUserId(string? email);
        Task<User> GetUserById(int? userId);
        Task DeleteUser(int? userId);
        void Save();
        Task<List<User>> GetUsers();
        void InsertUser(User user);
    }
}
