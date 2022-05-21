using System.ComponentModel.DataAnnotations;

namespace petrol_pricer_server.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int? CoordsId { get; set; }
        public int? PricesId { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
