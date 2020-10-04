﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Resources
{
    public class SalesObjectResource
    {
        public int SalesObjectId { get; set; }
        public Car Car { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public bool InStock { get; set; }
        public DateTime StartDate { get; set; }
    }
}