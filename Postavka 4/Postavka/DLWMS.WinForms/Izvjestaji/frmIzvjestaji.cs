using DLWMS.WinForms.IB200020;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        List<StudentiScan> skenovi = new List<StudentiScan>();
        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(List<StudentiScan> s):this()
        {
            this.skenovi = s;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tabela = new dsDLWMS.PolozeniDataTable();
            int brojac = 1;
            foreach (var s in skenovi)
            {
                var red = tabela.NewPolozeniRow();
                red.RedniBroj = brojac++;
                red.Predmet = s.Predmet.Naziv;
                red.Varanje = s.Varanje ? "varao" : "Nije varao";
                red.Napomena = s.Napomena;
                tabela.Rows.Add(red);
            }
            rds.Name = "dsDLWMS";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
