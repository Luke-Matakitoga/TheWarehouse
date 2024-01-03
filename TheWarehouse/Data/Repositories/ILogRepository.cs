using System.Collections.Generic;
using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public interface ILogRepository : IDisposable
    {
        void Log(string message);
        IEnumerable<Log> GetAllLogs(int howMany = 10);
        void DeleteLog(int? logId);
        public Task Save();
    }
}
