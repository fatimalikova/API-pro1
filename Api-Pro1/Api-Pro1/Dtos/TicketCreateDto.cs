using EventManagementAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Pro1.Dtos
{
    public class TicketCreateDto
    {
        public int EventId { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
    }
}
