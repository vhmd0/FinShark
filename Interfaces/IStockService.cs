using finshark.Dtos;
using finshark.Model;

namespace finshark.Interfaces
{
    public interface IStockService
    {
        Task<List<StockDto>> GetAllAsync();
        Task<StockDto?> GetByIdAsync(Guid id);
        Task<StockDto> CreateAsync(CreateStockRequestDto stockDto);
        Task<StockDto?> UpdateAsync(Guid id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(Guid id);
    }
}
