using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class TipAutobusa
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public TipAutobusa(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
    }
}
