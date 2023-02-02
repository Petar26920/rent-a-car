using Microsoft.AspNetCore.Mvc;
using pokusajNecega3.Models;
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
            ViewBag.SvaVozila = vozilo.NadjiSvaVozila();
            return View();
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


        [HttpPost]
        public IActionResult DodajVozilo()
        {
            return PartialView(vozilo.NadjiSvaVozila());
        }






    }
}
