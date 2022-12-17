using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosarkaskiSavez
{
    internal class Sudija
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Sudija(int id, string ime, string prezime)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
        }
        public string IspisSudije()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
