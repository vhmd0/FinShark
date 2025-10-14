namespace finshark.Dtos;

public class StockDto()
{
    public Guid Id { get; set; }
    public string Symbol { get; set; } = "";
    public string CompanyName { get; set; } = "";
    public decimal Purchase { get; set; }
    public decimal LastDiv { get; set; }
    public string Industry { get; set; } = "";
    public long MarketCap { get; set; }
}