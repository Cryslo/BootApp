using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Huurcontract
    {
        public string naam;
        public string email;
        public string verhuurder;
        public string boot;
        public string artikelen;
        public string datumstart;
        public string datumeind;

        public Huurcontract(string naam, string email, string verhuurder, string boot, string artikelen, string datumstart, string datumeind)
        {
            this.naam = naam;
            this.email = email;
            this.verhuurder = verhuurder;
            this.boot = boot;
            this.artikelen = artikelen;
            this.datumstart = datumstart;
            this.datumeind = datumeind;
            
        }
    }
}
