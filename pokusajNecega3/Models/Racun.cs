using System;
using System.Collections.Generic;

namespace pokusajNecega3.Models
{
    public partial class Racun
    {
        public int RacunId { get; set; }
        public string VoziloFk { get; set; }
        public int DokumentacijaFk { get; set; }
        public decimal Cena { get; set; }
        public int BrojDana { get; set; }
        public DateTime Datum { get; set; }

        public Dokumentacija DokumentacijaFkNavigation { get; set; }
        public Vozilo VoziloFkNavigation { get; set; }
    }
}
