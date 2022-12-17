using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1Termin02DomaciZadatak.src.Zadatak3
{
	class Nastavnik
	{
		public int NastavnikId { get; set; }
		public string NastavnikIme { get; set; }
		public string NastavnikPrezime { get; set; }
		public string NastavnikZvanje { get; set; }

		public Nastavnik(int nastavnikId, string nastavnikIme, string nastavnikPrezime, string nastavnikZvanje)
		{
			this.NastavnikId = nastavnikId;
			this.NastavnikIme = nastavnikIme;
			this.NastavnikPrezime = nastavnikPrezime;
			this.NastavnikZvanje = nastavnikZvanje;
		}
		public string PreuzmiTekstualnuReprezentacijuKlase()
		{
			return $"Nastavnik {NastavnikIme} {NastavnikPrezime}, {NastavnikZvanje}";
		}

    }
}
