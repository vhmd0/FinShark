namespace finshark.Dtos;

public class CreateCommentDto
{
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";

    public DateTime CreatedOn = DateTime.UtcNow;
}