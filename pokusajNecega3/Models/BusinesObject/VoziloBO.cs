using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.BusinesObject
{
    public class VoziloBO
    {
        public string RegistracioniBroj { get; set; }
        public string Tip { get; set; }
        public bool Zauzeto { get; set; }
        public string Boja { get; set; }
        public string Model { get; set; }
        public int vozniPark { get; set; }

        public int Tezina { get; set; }
    }
}
