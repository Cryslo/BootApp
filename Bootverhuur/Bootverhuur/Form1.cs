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
            dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
            cb_Boot.DataSource = dbAcess.Columnrequest("Artikel", "Artikelen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
        }

        private void btn_addtodb_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string naam = txt_naam.Text;
            string email = txt_Email.Text;
            string verhuurder = txt_Verhuurder.Text;
            string boot = cb_Boot.Text;
            string artikelen = cb_extraart.Text;
            string datumstart = dt_from.Value.ToShortDateString();
            string datumtot = dt_til.Value.ToShortDateString();
            
            dbAcess.Add_HuurderToDB(id, naam, email, verhuurder, boot, artikelen, datumstart, datumtot);
            dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
        }

        private void btn_delete_db_Click(object sender, EventArgs e)
        {

        }

        private void dt_from_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
