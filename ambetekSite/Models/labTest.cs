using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ambetekSite.Models
{
    public class labTest
    {
        public String ID { get; set; }
        public String testCode { get; set; }
        public String Description { get; set; }


        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
//        public testProvider Category { get; set; }
        public testCategory Category { get; set; }
    }
}
