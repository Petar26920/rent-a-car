using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.EFRepository
{
    public class KorisniciRepository : IKorisnici
    {
        private ProjekatZaPPPKojiRadiContext baza = new ProjekatZaPPPKojiRadiContext();
        public KorisniciBO nadjiKorisnika(string korisnickoIme,string sifra)
        {
            KorisniciBO korisnikBO = new KorisniciBO();
            foreach (Korisnici kor in baza.Korisnici)
            {
                if(kor.KorisnickoIme == korisnickoIme && kor.Sifra == sifra)
                {
                    korisnikBO.KorisnickoIme = kor.KorisnickoIme;
                    korisnikBO.Uloga = kor.Uloga;
                }
            }
            return korisnikBO;
        }
    }
}
