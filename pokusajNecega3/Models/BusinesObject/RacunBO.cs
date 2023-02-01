using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.BusinesObject
{
    public class RacunBO
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
