using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.BusinesObject
{
    public class DokuemntacijaBO
    {
        [Required(ErrorMessage ="Morate da unesete broj vozacke")]
        public int Idvozacke { get; set; }

        [Required(ErrorMessage ="Unesite ime")]
        public string? Ime { get; set; }
        [Required(ErrorMessage = "Unesite prezime")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Unesite datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }
        [Required(ErrorMessage = "Unesite datum izdavanja dozvole")]
        public DateTime DatumIzdavanjaDozvole { get; set; }
    }
}
