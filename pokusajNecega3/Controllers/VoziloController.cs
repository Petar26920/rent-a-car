using Microsoft.AspNetCore.Mvc;
using pokusajNecega3.Models;
using pokusajNecega3.Models.BusinesObject;
using pokusajNecega3.Models.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Controllers
{
    public class VoziloController : Controller
    {
        VoziloRepository vozilo;

        public VoziloController()
         {
            vozilo = new VoziloRepository();
        }

        public IActionResult Index()
        {
            ViewBag.Tipovi = vozilo.NadjiVozilaTogTipa();
            return View(vozilo.NadjiSvaVozila());
        }

        public ActionResult NadjiSvaVozilaTogTipa(string tip)
        {
            if(tip != "prazno")
            {
                return PartialView("ListaVozila", vozilo.NadjiSvaVozilaTogTipa(tip));
            }
            return PartialView("ListaVozila", vozilo.NadjiSvaVozila());
        }

        public IActionResult ListaVozila(string reg, bool iProlaz)
        {
            if (iProlaz == true)
            {
                return PartialView(vozilo.ListaVozila(reg));
            }
            else
            {
                return PartialView(vozilo.NadjiSvaVozila());
            }

        }





        public IActionResult NadjiVoziloPoReg(string reg, bool iProlaz)
        {
            if (iProlaz == true)
            {
                return PartialView(vozilo.NadjiVoziloPoReg(reg));
            }
            else
            {
                return PartialView(vozilo.NadjiSvaVozila());
            }

        }


        public IActionResult Dodaj()
        {
            ViewBag.Tip = vozilo.NadjiVozilaTogTipa();
            //ViewBag.Vozila = vozilo.NadjiSvaVozila();
            return View();
        }



        [HttpPost]
        public IActionResult DodajRacun(VoziloBO voziloBo)
        {
            //RacunBO racunBo = new RacunBO();
            //racunBo.RacunId = nID;
            //racunBo.VoziloFk = VozilaPregled;
            //racunBo.DokumentacijaFk = DokumentacijaPregled;
            //racunBo.Cena = nCen;
            //racunBo.BrojDana = nDan;
            //racunBo.Datum = nDat;

            if (vozilo.PostojiVoziloPoReg(voziloBo.RegistracioniBroj))
            {
                ModelState.AddModelError("RegistracioniBroj", "Postoji vec takav registracioni broj");
            }

            //if (racunBo.Cena <= 0 || String.IsNullOrEmpty(racunBo.Cena.ToString()))
            //{
            //    ModelState.AddModelError("Cena", "Cena mora biti veca od 0");
            //}

            //if (racunBo.DokumentacijaFk <= 0)
            //{
            //    ModelState.AddModelError("DokumentacijaFk", "Morate da izaberete dokumentaciju");
            //}

            //if (racunBo.BrojDana <= 0)
            //{
            //    ModelState.AddModelError("BrojDana", "Broj dana ne moze biti manji ili 0");
            //}


            if (ModelState.IsValid)
            {
                vozilo.KreirajVozilo(voziloBo);
                ViewBag.Uspeh = true;
                return View("ListaVozila", vozilo.NadjiSvaVozila());
            }
            ViewBag.Vozila = vozilo.NadjiSvaVozila();
            ViewBag.Tip = vozilo.NadjiVozilaTogTipa();
            return View("Dodaj", voziloBo);
        }



        [HttpPost]
        public IActionResult DodajVozilo(string nReg, string TipVozila, string nMod, bool nZauz, string nBoj, int nTez, int nVozPar)
        {
            VoziloBO voziloBo = new VoziloBO();
            voziloBo.RegistracioniBroj = nReg;
            voziloBo.Tip = TipVozila;
            voziloBo.Model = nMod;
            voziloBo.Zauzeto = nZauz;
            voziloBo.Boja = nBoj;
            voziloBo.Tezina = nTez;
            voziloBo.vozniPark = nVozPar;


            vozilo.DodajVozilo(voziloBo);
            return View("NadjiVoziloPoReg", vozilo.NadjiSvaVozila());
        }


        public IActionResult Brisi(string reg)
        {
            vozilo.Brisi(reg);
            /*Treba da promenis ime za partial view NadjiRacunPoID jer ga koristis i za nadji sve racune*/
            return PartialView("ListaVozila", vozilo.NadjiSvaVozila());
        }

    }
}
