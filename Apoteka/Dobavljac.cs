using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
    internal class Dobavljac
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Mesto { get; set; }
        public string Telefon { get; set; }

        public Dobavljac(int id, string naziv, string adresa, string mesto, string telefon)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
            Mesto = mesto;
            Telefon = telefon;
        }
    }
}
