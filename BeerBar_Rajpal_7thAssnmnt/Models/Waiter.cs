using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBar_Rajpal_7thAssnmnt.Models
{
    public class Waiter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
