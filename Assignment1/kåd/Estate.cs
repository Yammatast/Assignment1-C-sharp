using Assignment1.kåd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Estate
    {
        private int id;
        public Address address { get; }
        public LegalForm legalForm { get; set; }
        public Category category { get; set; }
        public BuildingType type { get; set; }

        public Estate(int id, Address address, LegalForm legalForm, Category category, BuildingType type)
        {
            this.id = id;
            this.address = address;
            this.legalForm = legalForm;
            this.category = category;
            this.type = type;
        }


    }
}
