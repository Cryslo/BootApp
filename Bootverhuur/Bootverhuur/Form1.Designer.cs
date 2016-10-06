namespace Bootverhuur
{
    partial class Form1
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
            this.dg_Huurders = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_naam = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Verhuurder = new System.Windows.Forms.TextBox();
            this.cb_Boot = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addtodb = new System.Windows.Forms.Button();
            this.btn_delete_db = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_extraart = new System.Windows.Forms.ComboBox();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.dt_til = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Huurders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // dg_Huurders
            // 
            this.dg_Huurders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Huurders.Location = new System.Drawing.Point(12, 395);
            this.dg_Huurders.Name = "dg_Huurders";
            this.dg_Huurders.Size = new System.Drawing.Size(973, 217);
            this.dg_Huurders.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_til);
            this.groupBox1.Controls.Add(this.dt_from);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.btn_addtodb);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_naam);
            this.groupBox1.Controls.Add(this.txt_Verhuurder);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toevoegen Huurder";
            // 
            // txt_naam
            // 
            this.txt_naam.Location = new System.Drawing.Point(6, 42);
            this.txt_naam.Name = "txt_naam";
            this.txt_naam.Size = new System.Drawing.Size(100, 20);
            this.txt_naam.TabIndex = 0;
            this.txt_naam.Text = "Naam";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(6, 68);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.Text = "Email";
            // 
            // txt_Verhuurder
            // 
            this.txt_Verhuurder.Location = new System.Drawing.Point(6, 94);
            this.txt_Verhuurder.Name = "txt_Verhuurder";
            this.txt_Verhuurder.Size = new System.Drawing.Size(100, 20);
            this.txt_Verhuurder.TabIndex = 2;
            this.txt_Verhuurder.Text = "Verhuurder";
            // 
            // cb_Boot
            // 
            this.cb_Boot.FormattingEnabled = true;
            this.cb_Boot.Location = new System.Drawing.Point(7, 19);
            this.cb_Boot.Name = "cb_Boot";
            this.cb_Boot.Size = new System.Drawing.Size(121, 21);
            this.cb_Boot.TabIndex = 3;
            this.cb_Boot.Text = "Boot";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(978, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_extraart);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_Boot);
            this.groupBox2.Location = new System.Drawing.Point(6, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikelen";
            // 
            // btn_addtodb
            // 
            this.btn_addtodb.Location = new System.Drawing.Point(5, 289);
            this.btn_addtodb.Name = "btn_addtodb";
            this.btn_addtodb.Size = new System.Drawing.Size(129, 22);
            this.btn_addtodb.TabIndex = 5;
            this.btn_addtodb.Text = "Voeg to aan database";
            this.btn_addtodb.UseVisualStyleBackColor = true;
            this.btn_addtodb.Click += new System.EventHandler(this.btn_addtodb_Click);
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
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(6, 19);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 6;
            this.txt_ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Extra artikelen?";
            // 
            // cb_extraart
            // 
            this.cb_extraart.FormattingEnabled = true;
            this.cb_extraart.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.cb_extraart.Location = new System.Drawing.Point(7, 63);
            this.cb_extraart.Name = "cb_extraart";
            this.cb_extraart.Size = new System.Drawing.Size(121, 21);
            this.cb_extraart.TabIndex = 8;
            this.cb_extraart.Text = "Nee";
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(6, 237);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(200, 20);
            this.dt_from.TabIndex = 7;
            this.dt_from.Value = new System.DateTime(2016, 10, 6, 0, 0, 0, 0);
            this.dt_from.ValueChanged += new System.EventHandler(this.dt_from_ValueChanged);
            // 
            // dt_til
            // 
            this.dt_til.Location = new System.Drawing.Point(6, 263);
            this.dt_til.Name = "dt_til";
            this.dt_til.Size = new System.Drawing.Size(200, 20);
            this.dt_til.TabIndex = 8;
            this.dt_til.Value = new System.DateTime(2016, 10, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum van en tot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.btn_delete_db);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dg_Huurders);
            this.Controls.Add(this.btn_refresh);
            this.Name = "Form1";
            this.Text = "Boten Verhuur";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Huurders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dg_Huurders;
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
        private System.Windows.Forms.ComboBox cb_Boot;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_extraart;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_til;
    }
}

