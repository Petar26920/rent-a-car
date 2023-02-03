using Microsoft.AspNetCore.Mvc;
using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Controllers
{
    public class RacunController : Controller
    {
        RacunRepository racunRep = new RacunRepository();
        public IActionResult Index()
        {
            return View(racunRep.NadjiSveRacune());
        }

        public IActionResult NadjiRacunPoID(int id,bool iProlaz)
        {
            if(iProlaz == true)
            {
                return PartialView(racunRep.NadjiRacunPoID(id));
            }
            else
            {
                return PartialView(racunRep.NadjiSveRacune());
            }
            
        }

        public IActionResult Brisi(int idRacuna)
        {
            racunRep.Brisi(idRacuna);
            /*Treba da promenis ime za partial view NadjiRacunPoID jer ga koristis i za nadji sve racune*/
            return PartialView("NadjiRacunPoID",racunRep.NadjiSveRacune());
        }

        
        public IActionResult Dodaj()
        {
            ViewBag.Vozila = racunRep.NadjiSvaVozila();
            ViewBag.Dokumentacija = racunRep.NadjiSvuDokumentaciju();
            return View();
        }

        //Ovo sam koristio kao ulazne argumente dole  int nID,string VozilaPregled,int DokumentacijaPregled, decimal nCen,int nDan, DateTime nDat

         [HttpPost]
        public IActionResult DodajRacun(RacunBO racunBo)
        {
            //RacunBO racunBo = new RacunBO();
            //racunBo.RacunId = nID;
            //racunBo.VoziloFk = VozilaPregled;
            //racunBo.DokumentacijaFk = DokumentacijaPregled;
            //racunBo.Cena = nCen;
            //racunBo.BrojDana = nDan;
            //racunBo.Datum = nDat;

            if (racunRep.PostojiRacunPoID(racunBo.RacunId))
            {
                ModelState.AddModelError("RacunId", "Postoji vec takav id racuna");
            }

            if (racunBo.Cena <= 0 || String.IsNullOrEmpty(racunBo.Cena.ToString()))
            {
                ModelState.AddModelError("Cena", "Cena mora biti veca od 0");
            }

            if(racunBo.DokumentacijaFk <= 0)
            {
                ModelState.AddModelError("DokumentacijaFk", "Morate da izaberete dokumentaciju");
            }

            if (racunBo.BrojDana <= 0)
            {
                ModelState.AddModelError("BrojDana", "Broj dana ne moze biti manji ili 0");
            }
            

            if (ModelState.IsValid)
            {
                racunRep.KreirajRacun(racunBo);
                ViewBag.Uspeh = true;
                return View("Index", racunRep.NadjiSveRacune());
            }
            ViewBag.Vozila = racunRep.NadjiSvaVozila();
            ViewBag.Dokumentacija = racunRep.NadjiSvuDokumentaciju();
            return View("Dodaj", racunBo);
        }
    }
}
