using finshark.Dtos;
using finshark.Interfaces;
using finshark.Mapper;
using finshark.Model;

namespace finshark.Services
{
    public class StockService : IStockService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StockService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<StockDto>> GetAllAsync()
        {
            var stocks = await _unitOfWork.StockRepository.GetAllAsync();
            return stocks.Select(s => s.ToStockDto()).ToList();
        }

        public async Task<StockDto?> GetByIdAsync(Guid id)
        {
            var stock = await _unitOfWork.StockRepository.GetByIdAsync(id);
            return stock?.ToStockDto();
        }

        public async Task<StockDto> CreateAsync(CreateStockRequestDto stockDto)
        {
            var stockModel = stockDto.ToStockFromCreateDTO();
            await _unitOfWork.StockRepository.CreateAsync(stockModel);
            await _unitOfWork.CompleteAsync();
            return stockModel.ToStockDto();
        }

        public async Task<StockDto?> UpdateAsync(Guid id, UpdateStockRequestDto stockDto)
        {
            var stockToUpdate = await _unitOfWork.StockRepository.GetByIdAsync(id);
            if (stockToUpdate == null)
            {
                return null;
            }

            stockDto.UpdateStockFromDto(stockToUpdate);
            await _unitOfWork.CompleteAsync();
            return stockToUpdate.ToStockDto();
        }

        public async Task<Stock?> DeleteAsync(Guid id)
        {
            var stockModel = await _unitOfWork.StockRepository.GetByIdAsync(id);
            if (stockModel == null)
            {
                return null;
            }

            _unitOfWork.StockRepository.Delete(stockModel);
            await _unitOfWork.CompleteAsync();
            return stockModel;
        }
    }
}
