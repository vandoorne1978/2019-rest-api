using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_rest_api
{
    public class Listing
    {
        public string Heading { get; set; }
        //  E.G. New Listing
        public string Type { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        //  Hull type.  E.G. Fibreglass
        public string Hull { get; set; }
        //  Engine type fuel type.  E.G. Diesel, gas.
        public string Engine { get; set; }
        public string YW { get; set; }
        public string[] Photos { get; set; }
        public string Broker { get; set; }
        public string Summary { get; set; }
    }
}
