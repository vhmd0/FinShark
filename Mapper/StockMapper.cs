using finshark.Dtos;
using finshark.Model;
using Riok.Mapperly.Abstractions;

namespace finshark.Mapper;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
public static partial class StockMapper
{
    public static partial Stock ToStockFromUpdateDTO(this UpdateStockRequestDto stockDto);
    public static partial Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto);
    public static partial StockDto ToStockDto(this Stock stock);
    public static partial void UpdateStockFromDto(this UpdateStockRequestDto dto, [MappingTarget] Stock stock);
}