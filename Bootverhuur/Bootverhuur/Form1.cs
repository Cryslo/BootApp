using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootverhuur
{
    public partial class Form1 : Form
    {
        DatabaseAcess dbAcess;

        public Form1()
        {
            InitializeComponent();
            dbAcess = new DatabaseAcess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbAcess.Add_BoatToDB("6", "Roeiboot");
            List<string> listi = dbAcess.Columnrequest("Artikel", "Artikelen");
            MessageBox.Show(listi[6]);
        }
    }
}
