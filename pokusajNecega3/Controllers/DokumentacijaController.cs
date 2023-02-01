using Microsoft.AspNetCore.Mvc;
using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Controllers
{
    public class DokumentacijaController : Controller
    {
        DokumentacijaRepository dokumentacija = new DokumentacijaRepository();
        public IActionResult Index()
        {
            return View("DodavanjeDokumentacije");
        }

        [HttpPost]
        public IActionResult Kreiraj(int nVoz, string nIme, string nPrez,DateTime nRodj,DateTime nIzdavanje)
        {
            DokuemntacijaBO dokumentacijaBO = new DokuemntacijaBO();
            dokumentacijaBO.Idvozacke = nVoz;
            dokumentacijaBO.Ime = nIme;
            dokumentacijaBO.Prezime = nPrez;
            dokumentacijaBO.DatumRodjenja = nRodj;
            dokumentacijaBO.DatumIzdavanjaDozvole = nIzdavanje;

            dokumentacija.Dodaj(dokumentacijaBO);
            ViewBag.Uspeh = true;
            return View("DodavanjeDokumentacije",ViewBag);
        }
    }
}
