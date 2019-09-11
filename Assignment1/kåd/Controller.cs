using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.kåd
{
    class Controller
    {
        private LinkedList<Estate> estates = new LinkedList<Estate>();
        Address address = new Address();

        public void addToList(Address address, LegalForm legalForm, Category category, BuildingType buildingType)
        {
            if (estates.Count == 0)
            {
                int id = 0;
                Estate estate = new Estate(id, address, legalForm, category, buildingType);
                estates.AddLast(estate);
                Console.WriteLine("Count == 0");
            }
            else
            {
                int id = estates.Count;
                Estate estate = new Estate(id, address, legalForm, category, buildingType);
                estates.AddLast(estate);
                Console.WriteLine("Det blev else satsen istället king" + id);
            }
        }

        public String setToText(Address address)
        {
           return address.street.ToString() + "\n" + address.zipcode.ToString() + address.city.ToString() +
                 "\n" + address.country;
        }

        //public String getFromList()
        //{

            //return tastmannennn;
        //}
        public Address getAddress(String street, String zipcode, String city, Countries country)
        {
            return new Address(street, zipcode, city, country);
        }

    }
}
