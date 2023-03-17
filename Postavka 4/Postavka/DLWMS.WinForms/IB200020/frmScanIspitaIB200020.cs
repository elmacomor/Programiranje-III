using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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
    public partial class frmScanIspitaIB200020 : Form
    {
        Student _student = new Student();
        public frmScanIspitaIB200020()
        {
            InitializeComponent();
            dgvSelectIspita.AutoGenerateColumns = false;
        }
        public frmScanIspitaIB200020(Student s) : this()
        {
            _student = s;
        }
        private void frmScanIspitaIB200020_Load(object sender, EventArgs e)
        {
            UcitajScan();
        }

        private void UcitajScan()
        {
            dgvSelectIspita.DataSource =DLWMSdb.Baza.StudentiScan.Where(s => s.Student.Id == _student.Id).ToList();
            lblStudent.Text = _student.ToString();
        }

        private void dgvSelectIspita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var red = (dgvSelectIspita.Rows[e.RowIndex].DataBoundItem) as StudentiScan;
            if (e.ColumnIndex == 4)
            {
                if(MessageBox.Show("Jeste li sigurni da zelite obrisati podatke?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DLWMSdb.Baza.StudentiScan.Remove(red);
                    DLWMSdb.Baza.SaveChanges();
                    UcitajScan();
                }
            }
            else
            {
                Form f1 = new frmNoviScanIspitaIB200020(red);
                f1.ShowDialog();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmNoviScanIspitaIB200020(_student);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UcitajScan();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var skenovi = DLWMSdb.Baza.StudentiScan.ToList();
            Form frm = new frmIzvjestaj(skenovi);
            frm.ShowDialog();
        }
    }
}
