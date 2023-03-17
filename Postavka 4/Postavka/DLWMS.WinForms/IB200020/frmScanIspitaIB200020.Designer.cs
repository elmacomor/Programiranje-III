namespace DLWMS.WinForms.IB200020
{
    partial class frmScanIspitaIB200020
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
            this.dgvSelectIspita = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanIspita = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectIspita)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectIspita
            // 
            this.dgvSelectIspita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectIspita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.ScanIspita,
            this.Brisi});
            this.dgvSelectIspita.Location = new System.Drawing.Point(12, 54);
            this.dgvSelectIspita.Name = "dgvSelectIspita";
            this.dgvSelectIspita.RowHeadersWidth = 51;
            this.dgvSelectIspita.RowTemplate.Height = 24;
            this.dgvSelectIspita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectIspita.Size = new System.Drawing.Size(776, 346);
            this.dgvSelectIspita.TabIndex = 0;
            this.dgvSelectIspita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectIspita_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.Width = 125;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.Width = 125;
            // 
            // ScanIspita
            // 
            this.ScanIspita.DataPropertyName = "Scan";
            this.ScanIspita.HeaderText = "Scan ispita";
            this.ScanIspita.MinimumWidth = 6;
            this.ScanIspita.Name = "ScanIspita";
            this.ScanIspita.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(699, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(89, 29);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj scan ispita";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(699, 406);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(89, 32);
            this.btnPrintaj.TabIndex = 2;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(12, 25);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(176, 17);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "Pregled ispita za studenta:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(194, 25);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 20);
            this.lblStudent.TabIndex = 4;
            // 
            // frmScanIspitaIB200020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvSelectIspita);
            this.Name = "frmScanIspitaIB200020";
            this.Text = "frmScanIspitaIB200020";
            this.Load += new System.EventHandler(this.frmScanIspitaIB200020_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectIspita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectIspita;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn ScanIspita;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}