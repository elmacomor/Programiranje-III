using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200020
{
    public partial class frmNoviScanIspitaIB200020 : Form
    {
        StudentiScan var = new StudentiScan();
        bool forma=false;
        Student st = new Student();
        public frmNoviScanIspitaIB200020()
        {
            InitializeComponent();
        }
        public frmNoviScanIspitaIB200020(StudentiScan s) : this()
        {
            var = s;
            forma = true;
        }
        public frmNoviScanIspitaIB200020(Student student) : this()
        {
            st = student;
        }

        private void frmNoviScanIspitaIB200020_Load(object sender, EventArgs e)
        {
            cmbPredmeti.DataSource = DLWMSdb.Baza.Predmet.ToList();
            DodijeliPodatke();
        }

        private void DodijeliPodatke()
        {
            if (forma)
            {
                cmbPredmeti.SelectedIndex = var.Predmet.Id-1;
                cmbPredmeti.Enabled = false;
                txtNapomena.Text = var.Napomena;
                txtNapomena.Enabled = false;
                pcbSlika.Image = ImageHelper.FromByteToImage(var.Sken);
                pcbSlika.Enabled = false;
                cBVaranje.Checked = var.Varanje;
                cBVaranje.Enabled = false;
                btnSpasi.Enabled = false;
            }
        }

        private void pcbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var putanja = openFileDialog1.FileName;
                pcbSlika.Image = Image.FromFile(putanja);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                StudentiScan noviSken = new StudentiScan();
                noviSken.Predmet = (cmbPredmeti.SelectedItem) as Predmet;
                noviSken.Napomena = txtNapomena.Text;
                noviSken.Student = st;
                noviSken.Varanje = cBVaranje.Checked;
                noviSken.Sken = ImageHelper.FromImageToByte(pcbSlika.Image);
                DLWMSdb.Baza.StudentiScan.Add(noviSken);
                DLWMSdb.Baza.SaveChanges();
                MessageBox.Show("Uspješno dodani podaci o ispitu.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Greska");
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, err, "Obavezno polje") && Validator.ValidirajKontrolu(txtNapomena, err, "Obavezno polje") && Validator.ValidirajKontrolu(pcbSlika, err, "Obavezno polje");
        }
    }
}
