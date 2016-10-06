using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootApplicatie.Classes
{
    class Motorboot : Artikel
    {
        private string brandStof;
        private string werkradius;

        public string BrandStof
        {
            get;
            set;
        }
        public string Werkradius
        {
            get;
            set;
        }
    }
}
