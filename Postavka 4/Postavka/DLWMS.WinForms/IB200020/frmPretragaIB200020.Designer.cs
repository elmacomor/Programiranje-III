namespace DLWMS.WinForms.IB200020
{
    partial class frmPretragaIB200020
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnprikazi = new System.Windows.Forms.Button();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.lblSamoglasnici = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNajveci = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(13, 25);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(95, 17);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "Ime i prezime:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(115, 25);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(673, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Polozeni,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dataGridView1.Location = new System.Drawing.Point(16, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 334);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.Width = 125;
            // 
            // Polozeni
            // 
            this.Polozeni.DataPropertyName = "Polozeni";
            this.Polozeni.HeaderText = "Polozeni predmeti";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.Width = 125;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "BrojPolozenih";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.Width = 125;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.Width = 125;
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            this.Ispiti.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnprikazi);
            this.groupBox1.Controls.Add(this.lblZnakovi);
            this.groupBox1.Controls.Add(this.lblSuglasnici);
            this.groupBox1.Controls.Add(this.lblSamoglasnici);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading:";
            // 
            // btnprikazi
            // 
            this.btnprikazi.Location = new System.Drawing.Point(597, 156);
            this.btnprikazi.Name = "btnprikazi";
            this.btnprikazi.Size = new System.Drawing.Size(154, 34);
            this.btnprikazi.TabIndex = 12;
            this.btnprikazi.Text = "Prikaži informacije:";
            this.btnprikazi.UseVisualStyleBackColor = true;
            this.btnprikazi.Click += new System.EventHandler(this.btnprikazi_Click);
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.AutoSize = true;
            this.lblZnakovi.Location = new System.Drawing.Point(108, 182);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(0, 17);
            this.lblZnakovi.TabIndex = 8;
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.AutoSize = true;
            this.lblSuglasnici.Location = new System.Drawing.Point(108, 165);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(0, 17);
            this.lblSuglasnici.TabIndex = 9;
            // 
            // lblSamoglasnici
            // 
            this.lblSamoglasnici.AutoSize = true;
            this.lblSamoglasnici.Location = new System.Drawing.Point(108, 148);
            this.lblSamoglasnici.Name = "lblSamoglasnici";
            this.lblSamoglasnici.Size = new System.Drawing.Size(0, 17);
            this.lblSamoglasnici.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sadržaj info:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(18, 49);
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(733, 96);
            this.txtSadrzaj.TabIndex = 6;
            this.txtSadrzaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite sadržaj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblNajveci
            // 
            this.lblNajveci.AutoSize = true;
            this.lblNajveci.Location = new System.Drawing.Point(597, 412);
            this.lblNajveci.Name = "lblNajveci";
            this.lblNajveci.Size = new System.Drawing.Size(0, 17);
            this.lblNajveci.TabIndex = 5;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(439, 412);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(162, 17);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "Najveći prosjek ostvario:";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(183, 412);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 17);
            this.lblProsjek.TabIndex = 7;
            // 
            // frmPretragaIB200020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 656);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblNajveci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblImePrezime);
            this.Name = "frmPretragaIB200020";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPretragaIB200020_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprikazi;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Label lblSuglasnici;
        private System.Windows.Forms.Label lblSamoglasnici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNajveci;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}