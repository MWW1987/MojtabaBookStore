﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MojtabaBookStore.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode1 { get; set; }
        public string PostalCode2 { get; set; }
        public string Tell { get; set; }
        public string Image { get; set; }

        public int CityID1 { get; set; }
        public int CityID2 { get; set; }

        public City city1 { get; set; }
        public City city2 { get; set; }
        public List<Order> Orders { get; set; }
    }
}
