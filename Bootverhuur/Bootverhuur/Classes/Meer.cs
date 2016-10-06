using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Meer
    {
        private string naam;
        private string locatie;

        public Meer(string initnaam, string initlocatie)
        {
            naam = initnaam;
            locatie = initlocatie;
        }
        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
            }
        }

        public string Locatie
        {
            get
            {
                return locatie;
            }

            set
            {
                locatie = value;
            }
        }
    }
}
