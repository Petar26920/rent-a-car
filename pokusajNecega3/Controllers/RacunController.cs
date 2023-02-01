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

        [HttpPost]
        public IActionResult DodajRacun(int nID,string VozilaPregled,int DokumentacijaPregled, decimal nCen,int nDan,DateTime nDat)
        {
            RacunBO racunBo = new RacunBO();
            racunBo.RacunId = nID;
            racunBo.VoziloFk = VozilaPregled;
            racunBo.DokumentacijaFk = DokumentacijaPregled;
            racunBo.Cena = nCen;
            racunBo.BrojDana = nDan;
            racunBo.Datum = nDat;

            racunRep.KreirajRacun(racunBo);
            return View("Index", racunRep.NadjiSveRacune());
        }
    }
}
