using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Motorboot : Boot
    {
        private int benzine;
        private int actieradius;

        public Motorboot(string naam, int initbenzine, int initactieradius) : base(naam)
        {
            this.Naam = naam;
            this.benzine = initbenzine;
            this.actieradius = initactieradius;
        }

        public int Benzine
        {
            get
            {
                return benzine;
            }

            set
            {
                benzine = value;
            }
        }

        public int Actieradius
        {
            get
            {
                return actieradius;
            }

            set
            {
                actieradius = value;
            }
        }
        public override string ToString()
        {
            return Naam + " Benzine: " + benzine + " Actieradius: " + actieradius;
        }
    }
}
