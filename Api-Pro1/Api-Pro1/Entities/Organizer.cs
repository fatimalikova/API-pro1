using System.ComponentModel.DataAnnotations;

namespace EventManagementAPI.Entities;

public class Organizer
{
    public int OrganizerId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string? LogoUrl { get; set; }

    public ICollection<Event> Events { get; set; } = new List<Event>();
}
