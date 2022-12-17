using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        //studenti koje pohađaju predmet
        public List<Student> Studenti { get; set; }

        //konstruktori
        // konstruktor bez parametra
        public Predmet()
        {
            Studenti = new List<Student>();
        }

        //konstruktor sa vise parametara
        public Predmet(int id, String naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }

        public Predmet(int id, String naziv, List<Student> studenti)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Studenti = studenti;
        }

        //metode
        public String PreuzmiTekstualnuReprezentacijuKlase()
        {
            String ispis = "Predmet sa id " + Id + " ima naziv "
                    + Naziv;
            return ispis;
        }

        public String PreuzmiPotpunuTekstualnuReprezentacijuKlase()
        {
            StringBuilder sb = new StringBuilder("Predmet sa id " + Id + " ima naziv "
                    + Naziv);

            if (Studenti != null)
            {
                sb.Append(" i pohađaju ga studenti\n");
                for (int i = 0; i < Studenti.Count; i++)
                {
                     sb.Append("\t" + Studenti[i].PreuzmiTekstualnuReprezentacijuKlase() + "\n");
                }
            }

            return sb.ToString();
        }

        //dva objekta su ista ako imaju isti id
        public bool Isti(Predmet pr)
        {
            bool isti = false;
            if (Id == pr.Id)
            {
                isti = true;
            }
            return isti;
        }
    }
}
