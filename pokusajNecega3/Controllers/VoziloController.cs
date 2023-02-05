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



        



        //[HttpPost]
        //public IActionResult DodajVozilo(string nReg, string TipVozila, string nMod, bool nZauz, string nBoj, int nTez, int nVozPar)
        //{
        //    VoziloBO voziloBo = new VoziloBO();
        //    voziloBo.RegistracioniBroj = nReg;
        //    voziloBo.Tip = TipVozila;
        //    voziloBo.Model = nMod;
        //    voziloBo.Zauzeto = nZauz;
        //    voziloBo.Boja = nBoj;
        //    voziloBo.Tezina = nTez;
        //    voziloBo.vozniPark = nVozPar;


        //    vozilo.DodajVozilo(voziloBo);
        //    return View("NadjiVoziloPoReg", vozilo.NadjiSvaVozila());
        //}

        [HttpPost]
        public IActionResult DodajVozilo(VoziloBO voziloBo)
        {
            //if (vozilo.PostojiVoziloPoReg(voziloBo.RegistracioniBroj))
            //{
            //    ModelState.AddModelError("RegistracioniBroj", "Postoji vec takav registracioni broj");
            //}

            //if (voziloBo.Tip == "Tip" || String.IsNullOrEmpty(voziloBo.Tip.ToString()))
            //{
            //    ModelState.AddModelError("Tip", "Tip mora biti izabran");
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
                //return View("NadjiSvaVozilaPoReg", vozilo.NadjiSvaVozila());

                return View("NadjiVoziloPoReg", vozilo.NadjiSvaVozila());
            }
            //ViewBag.VozniPark = vozilo.VozPark();
            ViewBag.Tip = vozilo.NadjiSveTipove();
            return View("Dodaj", voziloBo);
        }



        public IActionResult Brisi(string reg)
        {
            vozilo.Brisi(reg);
            /*Treba da promenis ime za partial view NadjiRacunPoID jer ga koristis i za nadji sve racune*/
            return PartialView("ListaVozila", vozilo.NadjiSvaVozila());
        }



        //Za radnika
        ///////////////////////////////////////////////////////

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
            //ViewBag.Vozila = vozilo.NadjiSvaVozila();
            ViewBag.Reg = vozilo.NadjiSveReg();
            return View();
        }

        public IActionResult AzurirajVozilo(VoziloBO voziloBo)
        {
            return View();
        }
    }
}
