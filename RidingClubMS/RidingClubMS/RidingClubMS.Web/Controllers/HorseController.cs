using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RidingClubMS.Services.Interfaces;

namespace RidingClubMS.Web.Controllers
{
    public class HorseController : Controller
    {
      
        private readonly IHorse IHorseService;

        public HorseController(IHorse _IHorseService)
        {
            IHorseService = _IHorseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetHorse(int HorseId)
        {
            var model = IHorseService.GetHorse(HorseId);

            return View(model);
        }
    }
}