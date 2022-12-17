using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosarkaskiSavez
{
    internal class Igrac
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Klub Klub { get; set; }

        public Igrac(int id, string ime, string prezime)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
        }

        public Igrac(int id, string ime, string prezime, Klub klub) : this(id, ime, prezime)
        {
            Klub = klub;
        }

        public string IspisIgraca()
        {
            return $"Igrac {Ime} {Prezime} igra za klub {((Klub != null) ? Klub.ToString() : "Nije definisano")}";
        }
    }
}
