using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaNewShore.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public List<Flight>ListFlight { get; set; }
        public List<Passenger> ListPassenger { get; set; }

        
    }
}