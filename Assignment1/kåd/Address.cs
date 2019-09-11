using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    struct Address
    {
        public String street { get; set; }
        public String zipcode { get; set; }
        public String city { get; set; }
        public Countries country { get; set; }

        public Address(String street, String zipcode, String city, Countries country)
        {
            this.street = street;
            this.zipcode = zipcode;
            this.city = city;
            this.country = country;
        }

    }
}
