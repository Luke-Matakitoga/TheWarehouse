namespace TheWarehouse.Data.Repositories
{
    public interface IUserRepository : IDisposable
    {
        int Login(string? username, string? password);
        int GetUserId(string? email);
    }
}
