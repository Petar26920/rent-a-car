using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models.EFRepository
{
    public class DokumentacijaRepository : IDokumentacijaRepository
    {
        ProjekatZaPPPKojiRadiContext baza = new ProjekatZaPPPKojiRadiContext();
        public void Dodaj(DokuemntacijaBO dokumentacijaBO)
        {
            Dokumentacija dokumentacija = new Dokumentacija();
            dokumentacija.Idvozacke = dokumentacijaBO.Idvozacke;
            dokumentacija.Ime = dokumentacijaBO.Ime;
            dokumentacija.Prezime = dokumentacijaBO.Prezime;
            dokumentacija.DatumRodjenja = dokumentacijaBO.DatumRodjenja;
            dokumentacija.DatumIzdavanjaDozvole = dokumentacijaBO.DatumIzdavanjaDozvole;

            baza.Dokumentacija.Add(dokumentacija);
            baza.SaveChanges();
        }
    }
}
