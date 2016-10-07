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
    public partial class BootApp : Form
    {
        DatabaseAcess dbAcess;
        private List<Huurcontract> contractlijst = new List<Huurcontract>();

        public BootApp()
        {
            InitializeComponent();
            dbAcess = new DatabaseAcess();
            dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
            UpdateBoten();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
        }

        private void btn_addtodb_Click(object sender, EventArgs e)
        {
            Huurcontract newcontract = new Huurcontract(
            txt_naam.Text,
            txt_Email.Text,
            txt_Verhuurder.Text,
            cb_Boot.Text,
            cb_extraart.Text,
            dt_from.Value.ToShortDateString(),
            dt_til.Value.ToShortDateString());
            contractlijst.Add(newcontract);

            dbAcess.Add_HuurderToDB(newcontract);
            dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
        }

        private void btn_delete_db_Click(object sender, EventArgs e)
        {
            try
            {
                dbAcess.Delete_HuurContract(Convert.ToInt32(dg_Huurders.SelectedRows[0].Cells[0].Value));
                dg_Huurders.DataSource = dbAcess.GetVerhuurders("HuurContracten");
            }
            catch (Exception)
            {

            }
        }

        private void dt_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_addboat_Click(object sender, EventArgs e)
        {
            //Add boot aan de lijst/DB
            Boot boot = new Boot(txt_bootnaam.Text);
            dbAcess.Add_BootToDB(boot);
            UpdateBoten();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Motorboot motorboot = new Motorboot(txt_mtrbootnaam.Text, Convert.ToInt32(txt_brandstof.Value), Convert.ToInt32(txt_actieradius.Value));
            dbAcess.Add_BootToDB(motorboot);
            UpdateBoten();
        }

        private void btn_boten_refresh_Click(object sender, EventArgs e)
        {
            UpdateBoten();
        }

        private void btn_boot_del_Click(object sender, EventArgs e)
        {
            try
            {
                dbAcess.Delete_BootFromDB(Convert.ToInt32(dg_boten.SelectedRows[0].Cells[0].Value));
                dg_boten.DataSource = dbAcess.GetBoten("Boten");
            }
            catch (Exception)
            {
                
            }
        }
        private void UpdateBoten()
        {
            dg_boten.DataSource = dbAcess.GetBoten("Boten");
            cb_Boot.DataSource = dbAcess.Columnrequest("Boot", "Boten");
        }
    }
}
