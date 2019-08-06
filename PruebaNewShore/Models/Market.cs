﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaNewShore.Models
{
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IataCode { get; set; }
        public string Country { get; set; }
    }
}