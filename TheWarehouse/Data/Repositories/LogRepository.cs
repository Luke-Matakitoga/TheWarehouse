using TheWarehouse.Data.Models;

namespace TheWarehouse.Data.Repositories
{
    public class LogRepository : ILogRepository, IDisposable
    {
        private WarehouseDbContext context;
        public LogRepository(WarehouseDbContext context)
        {
            this.context = context;
        }
        public void Log(string message)
        {
            context.Add(new Log { TimeStamp = DateTime.Now, Message = message });
        }
        public IEnumerable<Log> GetAllLogs(int howMany = 10)
        {
            return context.Logs
                            .OrderByDescending(l=>l.Id)
                            .Take(howMany);
        }
        public void DeleteLog(int? logId)
        {
            context.Logs.Remove(context.Logs.Find(logId));
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
