using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaNewShore.Models
{
    public class PruebaNewShoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PruebaNewShoreContext() : base("name=PruebaNewShoreContext")
        {
        }

        public System.Data.Entity.DbSet<PruebaNewShore.Models.Passenger> Passengers { get; set; }

        public System.Data.Entity.DbSet<PruebaNewShore.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<PruebaNewShore.Models.Flight> Flights { get; set; }

        public System.Data.Entity.DbSet<PruebaNewShore.Models.Booking> Bookings { get; set; }
    }
}
