using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBar_Rajpal_7thAssnmnt.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
