using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200020
{
    public class Statistika
    {
        public virtual Student Student { get; set; }
        public string Polozeni { get; set; }
        public int BrojPolozenih { get; set; }
        public double Prosjek { get; set; }
    }
}
