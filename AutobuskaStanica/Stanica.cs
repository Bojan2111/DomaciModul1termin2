using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class Stanica
    {
        public int Id { get; set; }
        public string Sediste { get; set; }
        public List<Peron> Peroni { get; set; }

        public Stanica(int id, string sediste, List<Peron> peroni)
        {
            Id = id;
            Sediste = sediste;
            Peroni = peroni;
        }
    }
}
