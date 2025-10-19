using finshark.Dtos;
using finshark.Interfaces;
using finshark.Mapper;
using finshark.Model;


namespace finshark.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepo;

        public StockService(IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
        }

        public async Task<List<StockDto>> GetAllAsync()
        {
            var stocks = await _stockRepo.GetAllAsync();
            return stocks.Select(s => s.ToStockDto()).ToList();
        }

        public async Task<StockDto?> GetByIdAsync(Guid id)
        {
            var stock = await _stockRepo.GetByIdAsync(id);
            return stock?.ToStockDto();
        }

        public async Task<StockDto> CreateAsync(CreateStockRequestDto stockDto)
        {
            var stockModel = stockDto.ToStockFromCreateDTO();
            await _stockRepo.CreateAsync(stockModel);
            return stockModel.ToStockDto();
        }

        public async Task<StockDto?> UpdateAsync(Guid id, UpdateStockRequestDto stockDto)
        {
            var stockModel = stockDto.ToStockFromUpdateDTO();
            var updatedStock = await _stockRepo.UpdateAsync(id, stockModel);
            return updatedStock?.ToStockDto();
        }

        public async Task<Stock?> DeleteAsync(Guid id)
        {
            return await _stockRepo.DeleteAsync(id);
        }
    }
}
