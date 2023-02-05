using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.BusinesObject
{
    public class VoziloBO
    {
        [Required(ErrorMessage = "Morate da unesete registracioni broj")]
        [RegularExpression("[0-9]+", ErrorMessage = "Samo brojevi su priznati")]
        public string RegistracioniBroj { get; set; }

        [Required(ErrorMessage = "Morate da unesete tip vozila")]
        public string Tip { get; set; }

        public bool Zauzeto { get; set; }

        [Required(ErrorMessage = "Morate da unesete boju vozila")]
        public string Boja { get; set; }

        [Required(ErrorMessage = "Morate da unesete model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Morate da izaberete vozni park")]
        public int vozniPark { get; set; }


        [Required(ErrorMessage = "Morate da unesete tezinu")]
        [RegularExpression("[0-9]+", ErrorMessage = "Samo brojevi su priznati")]
        public double Tezina { get; set; }
    }
}
