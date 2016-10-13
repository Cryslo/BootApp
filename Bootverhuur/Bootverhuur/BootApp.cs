using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootverhuur
{
    public partial class BootApp : Form
    {
        private List<Huurcontract> contractlijst = new List<Huurcontract>();
        private List<Artikel> boten = new List<Artikel>(); 
        private List<Artikel> artikelen = new List<Artikel>();

        public BootApp()
        {
            InitializeComponent();
            //UpdateArtikelen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_addtodb_Click(object sender, EventArgs e)
        {
            Huurder huurder = new Huurder(txt_naam.Text, txt_Email.Text);
            List<Artikel> artk = new List<Artikel>();

            foreach (Object item in clb_exart.CheckedItems)
            {
                artikelen.Add(new Artikel(item.ToString()));
            }

            foreach (Object item in clb_Meren.CheckedItems)
            {
                artikelen.Add(new Artikel(item.ToString()));
            }

            Huurcontract newcontract = new Huurcontract(
            huurder,
            txt_Verhuurder.Text,
            artikelen,
            dt_from.Value.ToShortDateString(),
            dt_til.Value.ToShortDateString());

            contractlijst.Add(newcontract);
            
        }
        private void addArtikel()
        {

        }

        private void btn_delete_db_Click(object sender, EventArgs e)
        {

        }

        private void dt_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_addboat_Click(object sender, EventArgs e)
        {
            boten.Add(new Boot(txt_bootnaam.Text));
            UpdateArtikelen();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            boten.Add(new Motorboot(txt_bootnaam.Text, Convert.ToInt32(txt_brandstof.Value), Convert.ToInt32(txt_actieradius.Value)));
            UpdateArtikelen();
        }

        private void btn_boten_refresh_Click(object sender, EventArgs e)
        {
            UpdateArtikelen();
        }

        private void btn_boot_del_Click(object sender, EventArgs e)
        {

        }
        private void UpdateArtikelen()
        {
            lb_boten.Items.Clear();
            List<string> botenlist = new List<string>();
            try
            {
                foreach (Artikel boot in boten)
                {
                    lb_boten.Items.Add(boot);
                    botenlist.Add(boot.ToString());
                }
            }
            catch (Exception)
            {

            }
            string path = @"C:\Users\power\Documents\test.txt";
            File.WriteAllLines(path, botenlist);
            clb_boten.Items.Clear();
            foreach (string item in botenlist)
            {
                clb_boten.Items.Add(item);
            }
        }
    }
}
