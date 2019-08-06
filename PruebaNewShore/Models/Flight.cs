using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaNewShore.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime DepartureDate { get; set; }
        public Market DepartureStation { get; set; }
        public Market ArrivalStation { get; set; }
        public string FlightNumber { get; set; }
        public float Price { get; set; }
        public string Currency { get; set; }
    }
}