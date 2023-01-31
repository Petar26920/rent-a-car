using pokusajNecega3.Models.BusinesObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.Interface
{
    interface IKorisnici
    {
        KorisniciBO nadjiKorisnika(string korisnickoIme, string sifra);
    }
}
