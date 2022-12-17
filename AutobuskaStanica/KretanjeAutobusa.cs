using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobuskaStanica
{
    internal class KretanjeAutobusa
    {
        public int Id { get; set; }
        public Autobus Autobus { get; set; }
        public Stanica Stanica { get; set; }
        public Peron Peron { get; set; }
        public Dolazak Dolazak { get; set; }
        public Polazak Polazak { get; set; }

        public KretanjeAutobusa(int id, Autobus autobus, Stanica stanica, Peron peron, Dolazak dolazak, Polazak polazak)
        {
            Id = id;
            Autobus = autobus;
            Stanica = stanica;
            Peron = peron;
            Dolazak = dolazak;
            Polazak = polazak;
        }

        public string IspisVoznje()
        {
            return $"Autobus {Autobus.Registracija} prevoznika {Autobus.Prevoznik} iz {Autobus.Prevoznik.Sediste}\n" +
                $"dolazi na peron {Peron.Broj} u {Dolazak.Vreme} i polazi u {Polazak.Vreme}";
        }
    }
}
