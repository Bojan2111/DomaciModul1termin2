using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosarkaskiSavez
{
    internal class Klub
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<Igrac> Igraci { get; set; }

        public Klub(int id, string naziv, List<Igrac> igraci)
        {
            Id = id;
            Naziv = naziv;
            Igraci = igraci;
        }

        public string IspisKluba()
        {
            string igraci = "";
            if (Igraci != null)
            {
                foreach (Igrac i in Igraci)
                {
                    igraci += $"{i.Ime} {i.Prezime}, ";
                }
                return $"Klub {Naziv} cine igraci {igraci}";
            }
            return $"U klubu {Naziv} za sada ne igra nijedan igrac";
        }
    }
}
