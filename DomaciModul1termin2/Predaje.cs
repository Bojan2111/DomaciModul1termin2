using Modul1Termin02DomaciZadatak.src.Zadatak3;
using StudentskaSluzba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciModul1termin2
{
    internal class Predaje
    {
        public Nastavnik Nastavnik { get; set; }
        public Predmet Predmet { get; set; }

        public Predaje(Nastavnik nastavnik, Predmet predmet)
        {
            Nastavnik = nastavnik;
            Predmet = predmet;
        }
        public string PreuzmiTekstualnuReprezentacijuKlase()
        {
            return $"Nastavnik {Nastavnik.NastavnikIme} {Nastavnik.NastavnikPrezime} predaje {Predmet.Naziv}";
        }
    }
}
