namespace DLWMS.WinForms.IB200020
{
    partial class frmNoviScanIspitaIB200020
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.cBVaranje = new System.Windows.Forms.CheckBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(23, 98);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(281, 129);
            this.txtNapomena.TabIndex = 5;
            this.txtNapomena.Text = "";
            // 
            // cBVaranje
            // 
            this.cBVaranje.AutoSize = true;
            this.cBVaranje.Location = new System.Drawing.Point(23, 239);
            this.cBVaranje.Name = "cBVaranje";
            this.cBVaranje.Size = new System.Drawing.Size(136, 21);
            this.cBVaranje.TabIndex = 6;
            this.cBVaranje.Text = "Varanje na ispitu";
            this.cBVaranje.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(429, 237);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 7;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // pcbSlika
            // 
            this.pcbSlika.Location = new System.Drawing.Point(331, 39);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(173, 188);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlika.TabIndex = 4;
            this.pcbSlika.TabStop = false;
            this.pcbSlika.Click += new System.EventHandler(this.pcbSlika_Click);
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(23, 39);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(281, 24);
            this.cmbPredmeti.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNoviScanIspitaIB200020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 272);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.cBVaranje);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.pcbSlika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspitaIB200020";
            this.Text = "frmNoviScanIspitaIB200020";
            this.Load += new System.EventHandler(this.frmNoviScanIspitaIB200020_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.CheckBox cBVaranje;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider err;
    }
}