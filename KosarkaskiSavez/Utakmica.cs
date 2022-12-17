using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosarkaskiSavez
{
    internal class Utakmica
    {
        public int Id { get; set; }
        public string DatumIVreme { get; set; }
        public Klub Domacin { get; set; }
        public Klub Gost { get; set; }
        public List<Sudija> Sudije { get; set; }
        public int KoseviDomacin { get; set; }
        public int KoseviGost { get; set; }

        public Utakmica(int id, string datumIVreme, Klub domacin, Klub gost, List<Sudija> sudije, int koseviDomacin, int koseviGost)
        {
            Id = id;
            DatumIVreme = datumIVreme;
            Domacin = domacin;
            Gost = gost;
            Sudije = sudije;
            KoseviDomacin = koseviDomacin;
            KoseviGost = koseviGost;
        }

        public string IspisUtakmice()
        {
            if (Sudije != null)
            {
                string sudije = "";
                foreach (Sudija s in Sudije)
                {
                    sudije += $"{s.IspisSudije()}, ";
                }
                return $"Utakmica izmedju klubova {Domacin.Naziv} i {Gost.Naziv}, koja se odigrala {DatumIVreme} rezultovala je sa {KoseviDomacin}:{KoseviGost}." +
                $"\nSudije: {sudije}";
            }
            return $"Utakmica izmedju klubova {Domacin.Naziv} i {Gost.Naziv}, koja se odigrala {DatumIVreme} rezultovala je sa {KoseviDomacin}:{KoseviGost}.";
        }
    }
}
