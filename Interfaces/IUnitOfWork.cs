namespace finshark.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStockRepository StockRepository { get; }
        Task<int> CompleteAsync();
    }
}
