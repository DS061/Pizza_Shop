using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Shop.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string shop { get; set; }

        public int Price { get; set; }

        public int NumberOfStocks { get; set; }
    }
}
