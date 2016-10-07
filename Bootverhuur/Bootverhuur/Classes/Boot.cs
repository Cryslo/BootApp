using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Boot : Artikel
    {
        string naam;

        public Boot(string naam)
        {
            this.naam = naam;
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
