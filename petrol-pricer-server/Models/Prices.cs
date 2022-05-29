using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace petrol_pricer_server.Models
{
    public class Prices
    {
        public int Id { get; set; }
        public int StationId { get; set; }
        public float PB95 { get; set; }
        public float PB98 { get; set; }
        public float Diesel { get; set; }
        public float Gas { get; set; }
    }
}
