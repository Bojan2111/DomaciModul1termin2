using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
    internal class Apotekar
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }

        public Apotekar(int id, string ime, string prezime, string telefon)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
        }
        public Narudzbenica KreirajNarudzbenicu(int id, Apotekar apotekar, Dobavljac dobavljac, string datum, Lek lek, double cenaPoKomadu, int kolicina)
        {
            return new Narudzbenica(id, apotekar, dobavljac, datum, lek, cenaPoKomadu, kolicina);
        }
    }
}
