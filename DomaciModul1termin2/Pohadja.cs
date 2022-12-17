using StudentskaSluzba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciModul1termin2
{
    class Pohadja
    {
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }

        public Pohadja(Student student, Predmet predmet)
        {
            Student = student;
            Predmet = predmet;
        }
        public string PreuzmiTekstualnuReprezentacijuKlase()
        {
            return $"Student {Student.Ime} {Student.Prezime} pohadja predmet {Predmet.Naziv}";
        }
    }
}
