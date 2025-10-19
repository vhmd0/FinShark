
using finshark.Interfaces;
using finshark.Model;
using Microsoft.EntityFrameworkCore;

namespace finshark.Repositorys
{
    public class StockRepository : IStockRepository
    {
        private readonly AppDbContext _context;

        public StockRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Stock>> GetAllAsync()
        {
            return await _context.Stocks.ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(Guid id)
        {
            return await _context.Stocks.FindAsync(id);
        }

                public async Task<Stock> CreateAsync(Stock stockModel)
                { 
                    await _context.Stocks.AddAsync(stockModel);
                    return stockModel;
                }
        
                public void Delete(Stock stockModel)
                {
                    _context.Stocks.Remove(stockModel);
                }    }
}
