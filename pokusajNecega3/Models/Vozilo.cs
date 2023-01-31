using System;
using System.Collections.Generic;

namespace pokusajNecega3.Models
{
    public partial class Vozilo
    {
        public Vozilo()
        {
            Racun = new HashSet<Racun>();
        }

        public string RegistracioniBroj { get; set; }
        public int VozniParkFk { get; set; }
        public string Boja { get; set; }
        public double Tezina { get; set; }
        public string Tip { get; set; }
        public string Model { get; set; }
        public bool Zauzeto { get; set; }

        public VozniPark VozniParkFkNavigation { get; set; }
        public ICollection<Racun> Racun { get; set; }
    }
}
