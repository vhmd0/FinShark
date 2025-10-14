namespace finshark.Dtos;

public class CommentDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime CreatedOn { get; set; }
    public Guid? StockId { get; set; }
}