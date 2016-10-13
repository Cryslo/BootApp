using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Huurcontract
    {
        private string verhuurder;
        private string datumstart;
        private string datumeind;
        private List<Artikel> artikel;
        private Huurder huurder;

        public string Verhuurder
        {
            get
            {
                return verhuurder;
            }

            set
            {
                verhuurder = value;
            }
        }

        public string Datumstart
        {
            get
            {
                return datumstart;
            }

            set
            {
                datumstart = value;
            }
        }

        public string Datumeind
        {
            get
            {
                return datumeind;
            }

            set
            {
                datumeind = value;
            }
        }

        public Huurder Huurder
        {
            get
            {
                return huurder;
            }

            set
            {
                huurder = value;
            }
        }

        public List<Artikel> Artikel
        {
            get
            {
                return artikel;
            }

            set
            {
                artikel = value;
            }
        }

        public Huurcontract(Huurder huurder, string verhuurder, List<Artikel> artikel, string datumstart, string datumeind)
        {
            this.Huurder = huurder;
            this.Verhuurder = verhuurder;
            this.Artikel = artikel;
            this.Datumstart = datumstart;
            this.Datumeind = datumeind;
            
        }
    }
}
