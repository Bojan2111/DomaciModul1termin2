using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class Peron
    {
        public int Broj { get; set; }
        public List<Polazak> Polasci { get; set; }
        public List<Dolazak> Dolasci { get; set; }

        public Peron(int broj, List<Polazak> polasci, List<Dolazak> dolasci)
        {
            Broj = broj;
            Polasci = polasci;
            Dolasci = dolasci;
        }
    }
}
