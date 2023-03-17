using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200020
{
    public partial class frmPretragaIB200020 : Form
    {
        public frmPretragaIB200020()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPretragaIB200020_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Statistika> studenti=null)
        {
            dataGridView1.DataSource = studenti??Sve();
        }

        private List<Statistika> Sve()
        {
            var stat = new List<Statistika>();
            var studenti = DLWMSdb.Baza.Studenti.ToList();
            var StudentSaNajvecimProsjekom = new Student();
            var studentiPredmeti = DLWMSdb.Baza.StudentiPredmeti.ToList();
            double najveciProsjek = 0;
            double UkupanProsjek = 0;
            var br2 = 0;
            foreach (var s in studenti)
            {
                Statistika nova = new Statistika();
                nova.Student = s;
                double suma = 0;
                int brojac = 0;
                for (int i = 0; i < studentiPredmeti.Count; i++)
                {
                    if (s == studentiPredmeti[i].Student)
                    {
                        suma += studentiPredmeti[i].Ocjena;
                        brojac++;
                        nova.Polozeni += $"{studentiPredmeti[i].Predmet.Naziv}; ";
                    }
                }
                nova.BrojPolozenih = brojac;
                nova.Prosjek = brojac==0 ? 0: suma / brojac;
                if (brojac != 0)
                {
                    UkupanProsjek += nova.Prosjek;
                    br2++;
                }
                if (nova.Prosjek > najveciProsjek)
                {
                    StudentSaNajvecimProsjekom = nova.Student;
                }
                stat.Add(nova);
            }
            if (UkupanProsjek==0)
                lblNajveci.Text = "NOT SET";
            else
            {
                lblNajveci.Text = StudentSaNajvecimProsjekom.ToString();
            }
            lblProsjek.Text = br2==0?"0":(UkupanProsjek/br2).ToString();
            return stat;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.ToLower();
            var studenti = Sve();
            var pretraga = studenti.Where(s => s.Student.Ime.ToLower().Contains(filter) || s.Student.Prezime.ToLower().Contains(filter));
            UcitajStudente(pretraga.ToList());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var student = (dataGridView1.Rows[e.RowIndex].DataBoundItem as Statistika).Student;
                Form forma = new frmScanIspitaIB200020(student);
                forma.Show();
            }
        }

        private void btnprikazi_Click(object sender, EventArgs e)
        {
            var tekst = txtSadrzaj.Text.ToLower();
            Regex listaSamoglasnika = new Regex(@"[aeiou]",RegexOptions.IgnoreCase);
            Regex listaSuglasnika = new Regex(@"[a-z]", RegexOptions.IgnoreCase);
            Regex listaZnakova = new Regex(@"[?!<>*]");
            int samoglasnici = tekst.Where(x => listaSamoglasnika.IsMatch(x.ToString())).Count();
            int suglasnici = tekst.Where(x => listaSuglasnika.IsMatch(x.ToString()) && !listaSamoglasnika.IsMatch(x.ToString())).Count();
            int znakovi = tekst.Where(x => listaZnakova.IsMatch(x.ToString())).Count();
            lblSamoglasnici.Text = $"Samoglasnici:{samoglasnici}";
            lblSuglasnici.Text = $"Suglasnici:{suglasnici}";
            lblZnakovi.Text = $"Znakovi:{znakovi}";
        }
    }
}
