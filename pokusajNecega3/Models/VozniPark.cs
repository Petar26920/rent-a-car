using System;
using System.Collections.Generic;

namespace pokusajNecega3.Models
{
    public partial class VozniPark
    {
        public VozniPark()
        {
            Vozilo = new HashSet<Vozilo>();
        }

        public int VozniParkId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Vozilo> Vozilo { get; set; }
    }
}
