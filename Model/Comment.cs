using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finshark.Model;

[Table("Comments")]
public class Comment
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [Required] [MaxLength(200)] public string Title { get; set; } = "";
    [Required] [MaxLength(2000)] public string Content { get; set; } = "";

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public Guid? StockId { get; set; }

    public Stock? Stock { get; set; }
}