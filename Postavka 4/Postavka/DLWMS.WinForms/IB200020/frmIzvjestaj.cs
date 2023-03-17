using DLWMS.WinForms.Helpers;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestaj : Form
    {
        List<StudentiScan> skenovi = new List<StudentiScan>();
        public frmIzvjestaj()
        {
            InitializeComponent();
        }
        public frmIzvjestaj(List<StudentiScan> s) : this()
        {
            this.skenovi = s;
        }
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
             var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tabela = new DataSet1.StudentiScanDataTable();
            int brojac = 1;
            foreach(var s in skenovi)
            {
                var red = tabela.NewStudentiScanRow();
                red.RedniBroj = brojac++;
                red.Predmet = s.Predmet.Naziv;
                red.Varanje = s.Varanje ? "varao" : "Nije varao";
                red.Napomena = s.Napomena;
                tabela.Rows.Add(red);
            }
            rds.Name = "DataSet1";
            rds.Value = tabela;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
