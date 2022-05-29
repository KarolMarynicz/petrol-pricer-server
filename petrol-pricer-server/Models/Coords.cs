using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace petrol_pricer_server.Models
{
    public class Coords
    {
        public int Id { get; set; }
        public int StationId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
