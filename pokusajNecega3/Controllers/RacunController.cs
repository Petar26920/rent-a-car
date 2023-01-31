using Microsoft.AspNetCore.Mvc;
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
    }
}
