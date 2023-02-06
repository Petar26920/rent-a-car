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
                return PartialView("ListaVozilaRadnik", vozilo.NadjiSvaVozilaTogTipa(tip));
            }
            return PartialView("ListaVozilaRadnik", vozilo.NadjiSvaVozila());
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
            ViewBag.Tip = vozilo.NadjiSveTipove();
            return View();
        }


        [HttpPost]
        public IActionResult DodajVozilo(VoziloBO voziloBo)
        {
            if (vozilo.PostojiVoziloPoReg(voziloBo.RegistracioniBroj))
            {
                ModelState.AddModelError("RegistracioniBroj", "Postoji vec takav registracioni broj");
            }

            if (voziloBo.vozniPark!=1||voziloBo.vozniPark!=2)
            {
                ModelState.AddModelError("Tip", "Tip mora biti izabran");
            }

            if (ModelState.IsValid)
            {
                vozilo.KreirajVozilo(voziloBo);
                ViewBag.Uspeh = true;
                return View("NadjiVoziloPoReg", vozilo.NadjiSvaVozila());
            }
            ViewBag.Tip = vozilo.NadjiSveTipove();
            return View("Dodaj", voziloBo);
        }



        public IActionResult Brisi(string reg)
        {
            vozilo.Brisi(reg);
            return PartialView("ListaVozilaRadnik", vozilo.NadjiSvaVozila());
        }


        //ZA RADNIKA
        public IActionResult NadjiVoziloPoRegRadnik(string reg, bool iProlaz)
        {
            if (iProlaz == true)
            {
                return PartialView(vozilo.NadjiVoziloPoRegRadnik(reg));
            }
            else
            {
                return PartialView(vozilo.NadjiSvaVozila());
            }
        }


        public IActionResult ListaVozilaRadnik(string reg, bool iProlaz)
        {
            if (iProlaz != false)
            {
                return PartialView(vozilo.ListaVozilaRadnik(reg));
            }
            else
            {
                return PartialView(vozilo.NadjiSvaVozila());
            }
        }


        //AZURIRANJE
        /////////////////////////////////////////////////////
        public IActionResult Azuriraj()
        {
            ViewBag.Tip = vozilo.NadjiVozilaTogTipa();
            ViewBag.Reg = vozilo.NadjiSveReg();
            ViewBag.uspeh = false;
            return View();
        }

        public IActionResult NadjiVoziloZaAzuriranje(string reg)
        {
            ViewBag.Tip = vozilo.NadjiVozilaTogTipa();
            return PartialView(vozilo.NadjiVoziloPoReg(reg));
        }

        [HttpPost]
        public IActionResult AzurirajVozilo(string RegistracioniBroj, string TipVozila, string nMod, string nBoj, double nTez, int nVozPar, int nZauz)
        {
            VoziloBO voziloBO = new VoziloBO();
            voziloBO.RegistracioniBroj = RegistracioniBroj;
            voziloBO.Tip = TipVozila;
            voziloBO.Model = nMod;
            voziloBO.Boja = nBoj;
            voziloBO.Tezina = nTez;
            voziloBO.vozniPark = nVozPar;
            voziloBO.Zauzeto = (nZauz == 1) ? true : false;

            vozilo.AzurirajVozilo(voziloBO);

            ViewBag.Tip = vozilo.NadjiVozilaTogTipa();
            ViewBag.Reg = vozilo.NadjiSveReg();
            ViewBag.uspeh = true;
            return View("Azuriraj");
        }
    }
}