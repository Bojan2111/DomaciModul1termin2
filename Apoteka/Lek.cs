using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
    internal class Lek
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public Lek(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
    }
}
