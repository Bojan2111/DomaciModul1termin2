using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    //klasa
    class Student
    {
        //atributi tj property-i
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string Grad { get; set; }

        //predmete koje pohađa student
		// Predmeti[] predmeti
        public List<Predmet> Predmeti { get; set; }
        
        //konstruktori

        // konstruktor bez parametra
        public Student()
        {
            Predmeti = new List<Predmet>();
        }

        //konstruktor sa vise parametara
        public Student(int id, String indeks, String prezime, String ime, String grad)
        {
            this.Id = id;
            this.Indeks = indeks;
            this.Prezime = prezime;
            this.Ime = ime;
            this.Grad = grad;
        }

        public Student(int id, String indeks, String prezime, String ime, String grad, List<Predmet> predmeti)
        {
            this.Id = id;
            this.Indeks = indeks;
            this.Prezime = prezime;
            this.Ime = ime;
            this.Grad = grad;
            this.Predmeti = predmeti;
        }

        //metode
        public string PreuzmiTekstualnuReprezentacijuKlase()
        {
            String ispis = "Student sa id " + Id + " čije je ime i prezime "
                    + Ime + " " + Prezime + " ima indeks " + Indeks + " i zivi u gradu " + Grad;
            return ispis;
        }

        public string PreuzmiPotpunuTekstualnuReprezentacijuKlase()
        {
            StringBuilder sb = new StringBuilder("Student sa id " + Id + " čije je ime i prezime "
                    + Ime + " " + Prezime + " ima indeks " + Indeks + " i zivi u gradu " + Grad);

            if (Predmeti != null)
            {
                sb.Append(" i pohađa predmete\n");
                for (int i = 0; i < Predmeti.Count; i++)
                {
                     sb.Append("\t" + Predmeti[i].PreuzmiTekstualnuReprezentacijuKlase() + "\n");
                }
            }
            return sb.ToString();
        }

        //dva objekta su ista ako imaju isti id
        public bool Isti(Student pr)
        {
            bool isti = false;
            if (Id == pr.Id)
            {
                isti = true;
            }
            return isti;
        }

        public override bool Equals(object obj)
        {
            bool isti = false;
            if (obj == null || !(obj is Student))
            {
                //isti = false;
                return false;
            }
            Student s = (Student)obj;
            if (Id == s.Id)
            {
                return true;
            }
            else
                return false;
        }

        //public override string ToString()
        //{
        //    //return base.ToString();
        //    return $"ID studenta: {Id}, ime: {Ime}, Prezime: {Prezime}, Index: {Indeks}";
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}
