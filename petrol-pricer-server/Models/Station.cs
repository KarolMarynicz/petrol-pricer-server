using System.ComponentModel.DataAnnotations;

namespace petrol_pricer_server.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public virtual Coords Coords { get; set; }
        public virtual Prices Prices { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
