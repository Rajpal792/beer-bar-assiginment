using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerBar_Rajpal_7thAssnmnt.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int BrandID { get; set; }
        public int WaiterID { get; set; }
        public Brand Brand { get; set; }
        public Waiter Waiter { get; set; }
    }
}
