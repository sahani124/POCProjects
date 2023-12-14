using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProjectCore.Models
{
    public class Customer
    {
        // CustomerCode --> customerCode
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal CustomerAmount { get; set; }
    }
}
