using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class Autobus
    {
        public string Registracija { get; set; }
        public TipAutobusa Tip { get; set; }
        public Prevoznik Prevoznik { get; set; }

        public Autobus(string registracija, TipAutobusa tip, Prevoznik prevoznik)
        {
            Registracija = registracija;
            Tip = tip;
            Prevoznik = prevoznik;
        }
    }
}
