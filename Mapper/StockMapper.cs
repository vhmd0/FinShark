using finshark.Dtos;
using finshark.Model;
using Riok.Mapperly.Abstractions;

namespace finshark.Mapper;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
public partial class StockMapper
{
    public partial Stock ToStockFromUpdateDTO(UpdateStockRequestDto stockDto);
    public partial Stock ToStock(CreateStockRequestDto stockDto);
    public partial StockDto ToStockDto(Stock stock);
}