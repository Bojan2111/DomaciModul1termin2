using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class Dolazak
    {
        public int Id { get; set; }
        public string Vreme { get; set; }

        public Dolazak(int id, string vreme)
        {
            Id = id;
            Vreme = vreme;
        }
    }
}
