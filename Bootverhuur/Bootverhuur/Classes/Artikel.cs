using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Artikel
    {
        private string naam;

        public Artikel(string initnaam)
        {
            naam = initnaam;
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
    }
}
