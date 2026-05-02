using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EventManagementAPI.Entities;

public class Event
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(150)]
    public string Title { get; set; }
    //[Optional]
    [MaxLength(500)]
    public string? Description { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    [MaxLength(200)]
    public string Location { get; set; }
    
    public string? BannerImageUrl { get; set; }
    public int OrganizerId { get; set; }

    public Organizer Organizer { get; set; } = null!;
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
