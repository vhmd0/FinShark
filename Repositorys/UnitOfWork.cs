using finshark.Interfaces;
using finshark.Model;

namespace finshark.Repositorys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IStockRepository StockRepository { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            StockRepository = new StockRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
