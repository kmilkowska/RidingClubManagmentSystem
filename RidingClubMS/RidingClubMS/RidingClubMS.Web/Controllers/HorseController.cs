using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RidingClubMS.Services.Interfaces;
using RidingClubMS.BLL.Entities;

namespace RidingClubMS.Web.Controllers
{
    public class HorseController : Controller
    {
      
        private readonly IHorseService IHorseService;

        public HorseController(IHorseService _IHorseService)
        {
            IHorseService = _IHorseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetHorse(int HorseId)
        {
            var model = IHorseService.GetHorse(HorseId);

            return View(model);
        }

        [HttpGet]
        public IActionResult GetHorses()
        {
            var model = IHorseService.GetHorses();

            return View(model);
        }

        [HttpGet]
        public IActionResult GetHorsesByBreed(string HorseBreed)
        {
            var model = IHorseService.GetHorsesByBreed(HorseBreed);

            return View(model);
        }

        [HttpPost]
        public IActionResult AddHorse(Horse horse)
        {
            var model = IHorseService.AddHorse(horse);

            return View(model);
        }

        public IActionResult DeleteHorse(int HorseId)
        {
            var model = IHorseService.DeleteHorse(HorseId);

            return View(model);
        }

        public IActionResult EditHorse(int HorseId, Horse horse)
        {
            var model = IHorseService.EditHorse(HorseId, horse);
            return View(model);
        }

    }
}