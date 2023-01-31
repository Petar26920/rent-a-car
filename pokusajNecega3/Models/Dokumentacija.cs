using System;
using System.Collections.Generic;

namespace pokusajNecega3.Models
{
    public partial class Dokumentacija
    {
        public Dokumentacija()
        {
            Racun = new HashSet<Racun>();
        }

        public int Idvozacke { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumIzdavanjaDozvole { get; set; }

        public ICollection<Racun> Racun { get; set; }
    }
}
