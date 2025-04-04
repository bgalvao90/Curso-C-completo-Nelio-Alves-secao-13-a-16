﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula172.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        override public string ToString()
        {
            return  Id + ", " + Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Category.Name + ", " + Category.Tier;
        }
    }
}
