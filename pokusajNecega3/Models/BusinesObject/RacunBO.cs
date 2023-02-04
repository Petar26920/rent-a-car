using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.BusinesObject
{
    public class RacunBO
    {
        [Required(ErrorMessage ="Morate da unesete ID racuna")]
        [RegularExpression("[0-9]+",ErrorMessage ="Samo brojevi su priznati")]
        public int RacunId { get; set; }
        [Required(ErrorMessage ="Morate da izaberete registraciju vozila")]
        public string VoziloFk { get; set; }
        [Required(ErrorMessage ="Potrebno je da izaberete broj vozacke")]
        public int DokumentacijaFk { get; set; }
        [Required(ErrorMessage ="Potrebno je da unesete cenu")]
        public decimal Cena { get; set; }
        [Required(ErrorMessage ="Morate da unesete broj dana")]
        public int BrojDana { get; set; }
        [Required(ErrorMessage ="Morate da izaberete datum")]
        public DateTime Datum { get; set; }

        public Dokumentacija DokumentacijaFkNavigation { get; set; }
        public Vozilo VoziloFkNavigation { get; set; }
    }
}
