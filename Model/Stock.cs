using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finshark.Model;

[Table("Stocks")]
public class Stock
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required] [MaxLength(10)] public string Symbol { get; set; } = "";
    [Required] [MaxLength(200)] public string CompanyName { get; set; } = "";
    [Column(TypeName = "decimal(18,2)")] public decimal Purchase { get; set; }
    [Column(TypeName = "decimal(18,2)")] public decimal LastDiv { get; set; }
    [MaxLength(100)] public string Industry { get; set; } = "";
    public long MarketCap { get; set; }

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}