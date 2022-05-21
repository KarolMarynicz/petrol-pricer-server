using petrol_pricer_server.Models;

namespace petrol_pricer_server.Dtos
{
    public class StationDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public Coords? Coords { get; set; }
        public Prices? Prices { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
