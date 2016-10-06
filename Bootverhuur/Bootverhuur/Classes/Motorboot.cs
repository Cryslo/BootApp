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
            Naam = naam;
            benzine = initbenzine;
            actieradius = initactieradius;
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
    }
}
