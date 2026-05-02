namespace Api_Pro1.Dtos
{
    public class EventCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public int OrganizerId { get; set; }
    }
}
