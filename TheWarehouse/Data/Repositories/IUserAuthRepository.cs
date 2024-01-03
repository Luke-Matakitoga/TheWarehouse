using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public interface IUserAuthRepository : IDisposable
    {
        UserAuth CreateToken(int userId);
    }
}
