using System.ComponentModel.DataAnnotations;

namespace petrol_pricer_server.Models
{
    public class Coords
    {
        [Key]
        public int Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
