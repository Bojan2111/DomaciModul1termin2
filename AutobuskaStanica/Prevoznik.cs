using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class Prevoznik
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Sediste { get; set; }
        public List<Autobus> Autobusi { get; set; }

        public Prevoznik(int id, string naziv, string sediste, List<Autobus> autobusi)
        {
            Id = id;
            Naziv = naziv;
            Sediste = sediste;
            Autobusi = autobusi;
        }
    }
}
