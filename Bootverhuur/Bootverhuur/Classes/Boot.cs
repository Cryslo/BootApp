using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootverhuur
{
    public class Boot
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
        public void AddBoatToDB(string id)
        {
            DatabaseAcess db = new DatabaseAcess();
            //db.Add_BoatToDB(id, naam);
        }
    }
}
