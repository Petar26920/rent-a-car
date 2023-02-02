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

            if(dokumentacija.NadjiDokumentacijuPoID(dokuemntacijaBO.Idvozacke))
            {
                ModelState.AddModelError("Idvozacke", "Vec postoji vozacka sa ovim brojem");
            }

            if(dokuemntacijaBO.Idvozacke<=0)
            {
                ModelState.AddModelError("Idvozacke", "Ne moze da bude manje od 0 ili prazno");
            }

            if(dokuemntacijaBO.DatumRodjenja == null)
            {
                ModelState.AddModelError("DatumRodjenja", "Popunite ovo polje");
            }

            if (ModelState.IsValid)
            {
                dokumentacija.Dodaj(dokuemntacijaBO);
                ViewBag.Uspeh = true;
                return View("DodavanjeDokumentacije");

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
