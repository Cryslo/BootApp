using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootApplicatie
{
    class Huurder
    {
        private string naam;
        private string email;

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
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
