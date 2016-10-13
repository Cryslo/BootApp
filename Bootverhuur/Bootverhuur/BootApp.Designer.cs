namespace Bootverhuur
{
    partial class BootApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_til = new System.Windows.Forms.DateTimePicker();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.btn_addtodb = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clb_boten = new System.Windows.Forms.CheckedListBox();
            this.clb_exart = new System.Windows.Forms.CheckedListBox();
            this.clb_Meren = new System.Windows.Forms.CheckedListBox();
            this.txt_naam = new System.Windows.Forms.TextBox();
            this.txt_Verhuurder = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_boot_del = new System.Windows.Forms.Button();
            this.btn_boten_refresh = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_bootnaam = new System.Windows.Forms.TextBox();
            this.btn_addboat = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_actieradius = new System.Windows.Forms.NumericUpDown();
            this.txt_brandstof = new System.Windows.Forms.NumericUpDown();
            this.txt_mtrbootnaam = new System.Windows.Forms.TextBox();
            this.btn_addmotorboot = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_delete_db = new System.Windows.Forms.Button();
            this.lb_Contracten = new System.Windows.Forms.ListBox();
            this.lb_boten = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_actieradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_brandstof)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(12, 367);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(56, 22);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_til);
            this.groupBox1.Controls.Add(this.dt_from);
            this.groupBox1.Controls.Add(this.btn_addtodb);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_naam);
            this.groupBox1.Controls.Add(this.txt_Verhuurder);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toevoegen Huurder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum van en tot";
            // 
            // dt_til
            // 
            this.dt_til.Location = new System.Drawing.Point(6, 240);
            this.dt_til.Name = "dt_til";
            this.dt_til.Size = new System.Drawing.Size(200, 20);
            this.dt_til.TabIndex = 8;
            this.dt_til.Value = new System.DateTime(2016, 10, 6, 0, 0, 0, 0);
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(6, 214);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(200, 20);
            this.dt_from.TabIndex = 7;
            this.dt_from.Value = new System.DateTime(2016, 10, 6, 0, 0, 0, 0);
            this.dt_from.ValueChanged += new System.EventHandler(this.dt_from_ValueChanged);
            // 
            // btn_addtodb
            // 
            this.btn_addtodb.Location = new System.Drawing.Point(5, 266);
            this.btn_addtodb.Name = "btn_addtodb";
            this.btn_addtodb.Size = new System.Drawing.Size(129, 22);
            this.btn_addtodb.TabIndex = 5;
            this.btn_addtodb.Text = "Voeg to aan database";
            this.btn_addtodb.UseVisualStyleBackColor = true;
            this.btn_addtodb.Click += new System.EventHandler(this.btn_addtodb_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clb_boten);
            this.groupBox2.Controls.Add(this.clb_exart);
            this.groupBox2.Controls.Add(this.clb_Meren);
            this.groupBox2.Location = new System.Drawing.Point(6, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikelen";
            // 
            // clb_boten
            // 
            this.clb_boten.FormattingEnabled = true;
            this.clb_boten.Items.AddRange(new object[] {
            "Kano"});
            this.clb_boten.Location = new System.Drawing.Point(8, 19);
            this.clb_boten.Name = "clb_boten";
            this.clb_boten.Size = new System.Drawing.Size(226, 64);
            this.clb_boten.TabIndex = 12;
            // 
            // clb_exart
            // 
            this.clb_exart.FormattingEnabled = true;
            this.clb_exart.Items.AddRange(new object[] {
            "Zwemvest",
            "Paddels",
            "Kampeer spullen"});
            this.clb_exart.Location = new System.Drawing.Point(252, 19);
            this.clb_exart.Name = "clb_exart";
            this.clb_exart.Size = new System.Drawing.Size(120, 64);
            this.clb_exart.TabIndex = 11;
            // 
            // clb_Meren
            // 
            this.clb_Meren.FormattingEnabled = true;
            this.clb_Meren.Items.AddRange(new object[] {
            "Friesse Meren",
            "Noordzee",
            "Ijsselmeer"});
            this.clb_Meren.Location = new System.Drawing.Point(423, 20);
            this.clb_Meren.Name = "clb_Meren";
            this.clb_Meren.Size = new System.Drawing.Size(120, 64);
            this.clb_Meren.TabIndex = 10;
            // 
            // txt_naam
            // 
            this.txt_naam.Location = new System.Drawing.Point(6, 19);
            this.txt_naam.Name = "txt_naam";
            this.txt_naam.Size = new System.Drawing.Size(100, 20);
            this.txt_naam.TabIndex = 0;
            this.txt_naam.Text = "Huurder Naam";
            // 
            // txt_Verhuurder
            // 
            this.txt_Verhuurder.Location = new System.Drawing.Point(6, 71);
            this.txt_Verhuurder.Name = "txt_Verhuurder";
            this.txt_Verhuurder.Size = new System.Drawing.Size(100, 20);
            this.txt_Verhuurder.TabIndex = 2;
            this.txt_Verhuurder.Text = "Verhuurder";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(6, 45);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.Text = "Email";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 360);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Huurders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_boten);
            this.groupBox3.Controls.Add(this.btn_boot_del);
            this.groupBox3.Controls.Add(this.btn_boten_refresh);
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(951, 322);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boot Toevoegen";
            // 
            // btn_boot_del
            // 
            this.btn_boot_del.Location = new System.Drawing.Point(357, 12);
            this.btn_boot_del.Name = "btn_boot_del";
            this.btn_boot_del.Size = new System.Drawing.Size(117, 23);
            this.btn_boot_del.TabIndex = 7;
            this.btn_boot_del.Text = "Delete geselecteerde";
            this.btn_boot_del.UseVisualStyleBackColor = true;
            this.btn_boot_del.Click += new System.EventHandler(this.btn_boot_del_Click);
            // 
            // btn_boten_refresh
            // 
            this.btn_boten_refresh.Location = new System.Drawing.Point(275, 12);
            this.btn_boten_refresh.Name = "btn_boten_refresh";
            this.btn_boten_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_boten_refresh.TabIndex = 6;
            this.btn_boten_refresh.Text = "Refresh";
            this.btn_boten_refresh.UseVisualStyleBackColor = true;
            this.btn_boten_refresh.Click += new System.EventHandler(this.btn_boten_refresh_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(235, 220);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_bootnaam);
            this.tabPage4.Controls.Add(this.btn_addboat);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(227, 194);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Normale boot";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_bootnaam
            // 
            this.txt_bootnaam.Location = new System.Drawing.Point(6, 6);
            this.txt_bootnaam.Name = "txt_bootnaam";
            this.txt_bootnaam.Size = new System.Drawing.Size(100, 20);
            this.txt_bootnaam.TabIndex = 0;
            this.txt_bootnaam.Text = "Bootnaam";
            // 
            // btn_addboat
            // 
            this.btn_addboat.Location = new System.Drawing.Point(6, 32);
            this.btn_addboat.Name = "btn_addboat";
            this.btn_addboat.Size = new System.Drawing.Size(100, 23);
            this.btn_addboat.TabIndex = 3;
            this.btn_addboat.Text = "Voeg boot toe";
            this.btn_addboat.UseVisualStyleBackColor = true;
            this.btn_addboat.Click += new System.EventHandler(this.btn_addboat_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.txt_actieradius);
            this.tabPage5.Controls.Add(this.txt_brandstof);
            this.tabPage5.Controls.Add(this.txt_mtrbootnaam);
            this.tabPage5.Controls.Add(this.btn_addmotorboot);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(227, 194);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Motor boot";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ActieRadius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Brandstof";
            // 
            // txt_actieradius
            // 
            this.txt_actieradius.Location = new System.Drawing.Point(6, 96);
            this.txt_actieradius.Name = "txt_actieradius";
            this.txt_actieradius.Size = new System.Drawing.Size(120, 20);
            this.txt_actieradius.TabIndex = 10;
            // 
            // txt_brandstof
            // 
            this.txt_brandstof.Location = new System.Drawing.Point(6, 51);
            this.txt_brandstof.Name = "txt_brandstof";
            this.txt_brandstof.Size = new System.Drawing.Size(120, 20);
            this.txt_brandstof.TabIndex = 9;
            // 
            // txt_mtrbootnaam
            // 
            this.txt_mtrbootnaam.Location = new System.Drawing.Point(6, 6);
            this.txt_mtrbootnaam.Name = "txt_mtrbootnaam";
            this.txt_mtrbootnaam.Size = new System.Drawing.Size(100, 20);
            this.txt_mtrbootnaam.TabIndex = 8;
            this.txt_mtrbootnaam.Text = "Bootnaam";
            // 
            // btn_addmotorboot
            // 
            this.btn_addmotorboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmotorboot.Location = new System.Drawing.Point(5, 126);
            this.btn_addmotorboot.Name = "btn_addmotorboot";
            this.btn_addmotorboot.Size = new System.Drawing.Size(100, 23);
            this.btn_addmotorboot.TabIndex = 7;
            this.btn_addmotorboot.Text = "Voeg motorboot toe";
            this.btn_addmotorboot.UseVisualStyleBackColor = true;
            this.btn_addmotorboot.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(978, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Berekening";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_delete_db
            // 
            this.btn_delete_db.Location = new System.Drawing.Point(74, 367);
            this.btn_delete_db.Name = "btn_delete_db";
            this.btn_delete_db.Size = new System.Drawing.Size(62, 22);
            this.btn_delete_db.TabIndex = 5;
            this.btn_delete_db.Text = "Verwijder";
            this.btn_delete_db.UseVisualStyleBackColor = true;
            this.btn_delete_db.Click += new System.EventHandler(this.btn_delete_db_Click);
            // 
            // lb_Contracten
            // 
            this.lb_Contracten.FormattingEnabled = true;
            this.lb_Contracten.Location = new System.Drawing.Point(7, 395);
            this.lb_Contracten.Name = "lb_Contracten";
            this.lb_Contracten.Size = new System.Drawing.Size(978, 212);
            this.lb_Contracten.TabIndex = 6;
            // 
            // lb_boten
            // 
            this.lb_boten.FormattingEnabled = true;
            this.lb_boten.Location = new System.Drawing.Point(275, 47);
            this.lb_boten.Name = "lb_boten";
            this.lb_boten.Size = new System.Drawing.Size(511, 186);
            this.lb_boten.TabIndex = 7;
            // 
            // BootApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.lb_Contracten);
            this.Controls.Add(this.btn_delete_db);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_refresh);
            this.Name = "BootApp";
            this.Text = "Boten Verhuur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_actieradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_brandstof)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_naam;
        private System.Windows.Forms.TextBox txt_Verhuurder;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_addtodb;
        private System.Windows.Forms.Button btn_delete_db;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_til;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_bootnaam;
        private System.Windows.Forms.Button btn_addboat;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txt_mtrbootnaam;
        private System.Windows.Forms.Button btn_addmotorboot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_actieradius;
        private System.Windows.Forms.NumericUpDown txt_brandstof;
        private System.Windows.Forms.Button btn_boten_refresh;
        private System.Windows.Forms.Button btn_boot_del;
        private System.Windows.Forms.CheckedListBox clb_Meren;
        private System.Windows.Forms.CheckedListBox clb_exart;
        private System.Windows.Forms.ListBox lb_Contracten;
        private System.Windows.Forms.CheckedListBox clb_boten;
        private System.Windows.Forms.ListBox lb_boten;
    }
}

