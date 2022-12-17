using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
    internal class Narudzbenica
    {
        public int Id { get; set; }
        public Apotekar Apotekar { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public string Datum { get; set; }
        public Lek Lek { get; set; }
        public double CenaPoKomadu { get; set; }
        public int Kolicina { get; set; }

        public Narudzbenica(int id, Apotekar apotekar, Dobavljac dobavljac, string datum, Lek lek, double cenaPoKomadu, int kolicina)
        {
            Id = id;
            Apotekar = apotekar;
            Dobavljac = dobavljac;
            Datum = datum;
            Lek = lek;
            CenaPoKomadu = cenaPoKomadu;
            Kolicina = kolicina;
        }
        public string IspisNarudzbenice()
        {
            return $"Datum: {Datum}\n" +
                $"Narudzbenica br. {Id}\n" +
                $"Apotekar {Apotekar.Ime} {Apotekar.Prezime} narucuje od dobavljaca {Dobavljac.Naziv}\n" +
                $"Naziv leka: {Lek.Naziv} ukupno {Kolicina} komada po jedinicnoj ceni od {CenaPoKomadu} RSD/kom";
        }
    }
}
