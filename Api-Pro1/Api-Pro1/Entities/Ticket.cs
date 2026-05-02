using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementAPI.Entities;

public class Ticket
{
    [Key]
    public int Id { get; set; }
    public int EventId { get; set; }
    [Required]
    [MaxLength(50)]
    public string Type { get; set; } = string.Empty;
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity available must be a non-negative integer.")]
    public int QuantityAvailable { get; set; }

    public Event Event { get; set; } = null!;
}
