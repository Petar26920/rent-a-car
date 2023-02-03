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
        public IActionResult DodajVozilo(string nReg, string TipVozila,string nMod,bool nZauz,string nBoj,int nTez,int nVozPar)
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
            return View("ListaVozila",vozilo.NadjiSvaVozila());
        }


        public IActionResult Brisi()
        {
            return View();
        }

    }
}
