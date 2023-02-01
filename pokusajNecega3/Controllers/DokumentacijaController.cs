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
        public IActionResult Kreiraj(DokuemntacijaBO dokuemntacijaBO)
        {

            //DokuemntacijaBO dokumentacijaBO = new DokuemntacijaBO();
            //dokumentacijaBO.Idvozacke = nVoz;
            //dokumentacijaBO.Ime = nIme;
            //dokumentacijaBO.Prezime = nPrez;
            //dokumentacijaBO.DatumRodjenja = nRodj;
            //dokumentacijaBO.DatumIzdavanjaDozvole = nIzdavanje;

            if (ModelState.IsValid)
            {
                dokumentacija.Dodaj(dokuemntacijaBO);

                //ViewBag.Uspeh = true;
                return View("DodavanjeDokumentacije" /*ViewBag*/);

            }

            return View("DodavanjeDokumentacije", dokuemntacijaBO);
        }
        //public IActionResult Kreiraj(int nVoz, string nIme, string nPrez, DateTime nRodj, DateTime nIzdavanje)
        //{

        //    DokuemntacijaBO dokumentacijaBO = new DokuemntacijaBO();
        //    dokumentacijaBO.Idvozacke = nVoz;
        //    dokumentacijaBO.Ime = nIme;
        //    dokumentacijaBO.Prezime = nPrez;
        //    dokumentacijaBO.DatumRodjenja = nRodj;
        //    dokumentacijaBO.DatumIzdavanjaDozvole = nIzdavanje;

        //    if (ModelState.IsValid)
        //    {
        //        dokumentacija.Dodaj(dokumentacijaBO);

        //        //ViewBag.Uspeh = true;
        //        return View("DodavanjeDokumentacije" /*ViewBag*/);

        //    }

        //    return View("DodavanjeDokumentacije", dokumentacijaBO);
        //}
    }
}
