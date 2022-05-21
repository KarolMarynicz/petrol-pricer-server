using System.ComponentModel.DataAnnotations;

namespace petrol_pricer_server.Models
{
    public class Prices
    {
        [Key]
        public int Id { get; set; }
        public float PB95 { get; set; }
        public float PB98 { get; set; }
        public float Diesel { get; set; }
        public float Gas { get; set; }
    }
}
