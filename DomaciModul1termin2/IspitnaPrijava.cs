using StudentskaSluzba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciModul1termin2
{
    internal class IspitnaPrijava
    {
        /*
         * Izmodelovati entitet IspitnePrijava i smestiti je u Modul1Termin02.Primer6 prostor imena. Klasa
         * IspitnePrijave su opisani poljima student, predmet, ispitni rok, broj bodova na teoriji i broj bodova
         * na zadacima.
         * Obezbediti da su svi atributi zaštićeni i da postoji više konstuktora. Implementirati sledeće metode:
         * 
         * PreuzmiTekstualnuReprezentacijuKlase() – vraća potpunu tekstualnu reprezentaciju klase
         * 
         * Isti(IspitnePrijava ip) – poredi dva objekta tipa IspitnePrijava i vraća bool vrednost
         * 
         * IzracunajOcenu() – računa ocenu (od 5 do 10) na osnovu bodova na teoriji i zadacima
         * 
         * IzracunajProsek() – računa prosečan broj bodova ostvaren na teoriji i zadacima
         * Dodatno implementirati set/get metode (property-e) za atibute klase.
         * Izmeniti MainClass1 klasu tako da se kreira lista ispitnih prijava i ispisuje.
         * Test podatke preuzeti (prekopirati ručno) iz datoteke ispitne_prijave.csv.
         */
        private Student _student;

        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }
        private Predmet _predmet;

        public Predmet Predmet
        {
            get { return _predmet; }
            set { _predmet = value; }
        }
        private IspitniRok _ispitniRok;

        public IspitniRok IspitniRok
        {
            get { return _ispitniRok; }
            set { _ispitniRok = value; }
        }
        private int _bodoviTeorija;

        public int BodoviTeorija
        {
            get { return _bodoviTeorija; }
            set { _bodoviTeorija = value; }
        }
        private int _bodoviZadaci;

        public int BodoviZadaci
        {
            get { return _bodoviZadaci; }
            set { _bodoviZadaci = value; }
        }

        public IspitnaPrijava(Student student, Predmet predmet, IspitniRok ispitniRok)
        {
            Student = student;
            Predmet = predmet;
            IspitniRok = ispitniRok;
        }

        public IspitnaPrijava(Student student, Predmet predmet, IspitniRok ispitniRok, int bodoviTeorija)
        {
            Student = student;
            Predmet = predmet;
            IspitniRok = ispitniRok;
            BodoviTeorija = bodoviTeorija;
        }

        public IspitnaPrijava(Student student, Predmet predmet, IspitniRok ispitniRok, int bodoviTeorija, int bodoviZadaci)
        {
            Student = student;
            Predmet = predmet;
            IspitniRok = ispitniRok;
            BodoviTeorija = bodoviTeorija;
            BodoviZadaci = bodoviZadaci;
        }
        public string PreuzmiTekstualnuReprezentacijuKlase()
        {
            return $"Student {Student.Ime} {Student.Prezime} prijavljuje ispit iz predmeta {Predmet.Naziv}\n" +
                $"u ispitnom roku {IspitniRok.Naziv} sa {BodoviTeorija} bodova iz teorije i {BodoviZadaci} bodova iz zadataka.";
        }

        public bool Isti(object obj)
        {
            if (obj == null || !(obj is IspitnaPrijava))
                return false;
            IspitnaPrijava novaPrijava = (IspitnaPrijava)obj;
            return this.Student == novaPrijava.Student && this.Predmet == novaPrijava.Predmet;
        }
    }
}
