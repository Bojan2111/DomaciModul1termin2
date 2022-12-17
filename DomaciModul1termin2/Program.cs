using DomaciModul1termin2;
using Modul1Termin02DomaciZadatak.src.Zadatak3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    class Program
    {
        //ispis
        public static void IspisiStudente(List<Student> lista)
        {
            //ispis svih studenata I NACIN
			// obavezno castovanje - da/ne ?
            for (int i = 0; i < lista.Count; i++)
            {
                Student st = (Student)lista[i];
                Console.WriteLine(st.PreuzmiPotpunuTekstualnuReprezentacijuKlase());
            }

            //ispis svih studenata II NACIN
            //foreach (Student st in lista)
            //{
            //    Console.WriteLine(st.PreuzmiTekstualnuReprezentacijuKlase());
            //}
        }

        public static void Main(String[] args)
        {
            // PREDMETI
            List<Predmet> sviPredmeti = new List<Predmet>();
            sviPredmeti.Add(new Predmet(1, "Matematika"));
            sviPredmeti.Add(new Predmet(2, "Fizika"));
            sviPredmeti.Add(new Predmet(3, "Elektrotehnika"));
            sviPredmeti.Add(new Predmet(4, "Informatika"));

            foreach (Predmet p in sviPredmeti)
            {
                Console.WriteLine(p.PreuzmiTekstualnuReprezentacijuKlase());
            }
            Console.WriteLine("\n------------------------------------------------------------\n");

            // NASTAVNICI
            List<Nastavnik> sviNastavnici = new List<Nastavnik>();

            sviNastavnici.Add(new Nastavnik(1,"Petar","Petrović","Docent"));
            sviNastavnici.Add(new Nastavnik(2,"Jovan","Jovanović","Docent"));
            sviNastavnici.Add(new Nastavnik(3,"Marko","Marković","Asistent"));
            sviNastavnici.Add(new Nastavnik(4,"Nikola","Nikolić","Redovni Profesor"));
            sviNastavnici.Add(new Nastavnik(5, "Lazar","Lazić","Asistent"));

            foreach (Nastavnik n in sviNastavnici)
            {
                Console.WriteLine(n.PreuzmiTekstualnuReprezentacijuKlase());
            }
            Console.WriteLine("\n------------------------------------------------------------\n");

            // PREDAJE
            List <Predaje> sviPredaje = new List<Predaje>();
            int[,] predajeUnos = new int[,] {
                { 1, 1 },
                { 1, 2 },
                { 1, 3 },
                { 2, 2 },
                { 3, 1 },
                { 4, 1 },
                { 4, 3 },
                { 4, 4 },
                { 5, 1 },
                { 5, 2 },
                { 5, 3 },
            };

            for (int i = 0; i < predajeUnos.GetLength(0); i++)
            {
                Nastavnik tempNastavnik = null;
                Predmet tempPredmet = null;
                foreach (Nastavnik n in sviNastavnici)
                {
                    if (n.NastavnikId == predajeUnos[i, 0])
                    {
                        tempNastavnik = n;
                        break;
                    }
                }
                foreach (Predmet p in sviPredmeti)
                {
                    if (p.Id == predajeUnos[i, 1])
                    {
                        tempPredmet = p;
                        break;
                    }
                }
                sviPredaje.Add(new Predaje(tempNastavnik, tempPredmet));
            }

            foreach (Predaje pred in sviPredaje)
            {
                Console.WriteLine(pred.PreuzmiTekstualnuReprezentacijuKlase());
            }
            Console.WriteLine("\n------------------------------------------------------------\n");

            // STUDENTI
            List<Student> sviStudenti = new List<Student>();

            sviStudenti.Add(new Student(1, "E1 01 / 2011", "Srđanov", "Konstantin", "Loznica"));
            sviStudenti.Add(new Student(2, "E1 02 / 2012", "Baki", "Strahinja", "Novi Sad"));
            sviStudenti.Add(new Student(3, "E1 03 / 2013", "Trajković", "Nebojša", "Inđija"));
            sviStudenti.Add(new Student(4, "E2 01 / 2011", "Sekulić", "Miloš", "Vršac"));
            sviStudenti.Add(new Student(5, "E2 02 / 2012", "Askin", "Vuk", "Novi Sad"));
            sviStudenti.Add(new Student(6, "E2 03 / 2013", "Klainić", "Marko", "Sombor"));
            sviStudenti.Add(new Student(7, "E2 04 / 2011", "Marko", "Panić", "Zrenjanin"));

            foreach (Student s in sviStudenti)
            {
                Console.WriteLine(s.PreuzmiTekstualnuReprezentacijuKlase());
            }
            Console.WriteLine("\n------------------------------------------------------------\n");

            // TO DO: Dodati predmete studentima i unutar svakog predmeta niz studenata 
            // koji pohađaju dati predmet
            // ispisati sve predmete zajedno sa studentima koji pohadjaju te predmete

            // POHADJA
            List<Pohadja> sviPohadja = new List<Pohadja>();

            int[,] pohadjaUnos = new int[,] {
                { 1, 1 },
                { 1, 2 },
                { 1, 3 },
                { 2, 2 },
                { 3, 2 },
                { 4, 1 },
                { 4, 3 },
                { 4, 4 },
                { 5, 3 },
                { 5, 4 },
            };

            for (int i = 0; i < pohadjaUnos.GetLength(0); i++)
            {
                Student tempStudent = null;
                Predmet tempPredmet = null;
                foreach (Student s in sviStudenti)
                {
                    if (s.Id == pohadjaUnos[i, 0])
                    {
                        tempStudent = s;
                        break;
                    }
                }
                foreach (Predmet p in sviPredmeti)
                {
                    if (p.Id == pohadjaUnos[i, 1])
                    {
                        tempPredmet = p;
                        break;
                    }
                }
                sviPohadja.Add(new Pohadja(tempStudent, tempPredmet));
            }
            foreach (Pohadja poh in sviPohadja)
            {
                Console.WriteLine(poh.PreuzmiTekstualnuReprezentacijuKlase());
            }
            Console.WriteLine("\n------------------------------------------------------------\n");

            // ISPITNI ROKOVI
            List<IspitniRok> sviRokovi = new List<IspitniRok>();

            IspitniRok januarski = new IspitniRok(1, "Januarski", "2015 - 01 - 15", "2015 - 01 - 29");
            IspitniRok februarski = new IspitniRok(2, "Februarski", "2015 - 02 - 01", "2015 - 02 - 14");

            sviRokovi.Add(januarski);
            sviRokovi.Add(februarski);
            // ISPIS ISPITNOG ROKA
            Console.WriteLine(januarski.PreuzmiTekstualnuReprezentacijuKlase());
            Console.WriteLine(februarski.PreuzmiTekstualnuReprezentacijuKlase());
            Console.WriteLine("\n------------------------------------------------------------\n");

            // ISPITNE PRIJAVE
            int[,] prijaveUnos = new int[,] { 
                { 1, 1, 1, 88, 89 }, 
                { 1, 2, 2, 85, 55 }, 
                { 2, 2, 2, 80, 45 }, 
                { 3, 1, 1, 94, 96 }, 
                { 4, 1, 1, 40, 60 }, 
                { 4, 1, 2, 83, 88 }, 
                { 4, 2, 2, 89, 91 }, 
                { 4, 4, 2, 100, 98 }, 
                { 5, 2, 1, 45, 47 }, 
                { 5, 3, 2, 56, 55 }, 
                { 6, 3, 2, 25, 0 }, 
            };
            List<IspitnaPrijava> svePrijave = new List<IspitnaPrijava>();

            for (int i = 0; i < prijaveUnos.GetLength(0); i++)
            {
                Student tempStudent = null;
                Predmet tempPredmet = null;
                IspitniRok tempRok = null;
                foreach (Student s in sviStudenti)
                {
                    if (s.Id == prijaveUnos[i, 0])
                    {
                        tempStudent = s;
                        break;
                    }
                }
                foreach (Predmet p in sviPredmeti)
                {
                    if (p.Id == prijaveUnos[i, 1])
                    {
                        tempPredmet = p;
                        break;
                    }
                }
                foreach (IspitniRok ir in sviRokovi)
                {
                    if (ir.Id == prijaveUnos[i, 2])
                    {
                        tempRok = ir;
                        break;
                    }
                }
                svePrijave.Add(new IspitnaPrijava(tempStudent, tempPredmet, tempRok, prijaveUnos[i, 3], prijaveUnos[i, 4]));
            }
            foreach (IspitnaPrijava ip in svePrijave)
            {
                Console.WriteLine(ip.PreuzmiTekstualnuReprezentacijuKlase());
            }
            Console.WriteLine("\n------------------------------------------------------------\n");

            Console.ReadKey();
        }
        
    }
}
