using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.BusinesObject
{
    public class DokuemntacijaBO
    {
        [Required(ErrorMessage ="Morate da unesete ID")]
        [RegularExpression("[0-9]+",ErrorMessage ="Mogu samo brojevi")]
        public int Idvozacke { get; set; }

        [Required(ErrorMessage ="Unesite ime")]
        [RegularExpression("[a-zA-Z]+",ErrorMessage ="Samo mala i velika slova")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Unesite prezime")]
        [RegularExpression("[a-zA-Z]+",ErrorMessage ="Samo mala i velika slova")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Unesite datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }

        [Required(ErrorMessage = "Unesite datum izdavanja dozvole")]
        public DateTime DatumIzdavanjaDozvole { get; set; }
    }
}
