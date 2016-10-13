using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Boot : Artikel
    {
        public Boot (string naam) : base(naam)
        {
            this.Naam = naam;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
