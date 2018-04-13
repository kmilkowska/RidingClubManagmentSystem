using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RidingClubMS.Services.Interfaces;
using RidingClubMS.BLL.Entities;
using Newtonsoft.Json;
using RidingClubMS.ViewModels.HorseJsonModels;

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
            List<HorseResultJson> res = new List<HorseResultJson>();
            foreach(var itm in model)
            {
                res.Add(new HorseResultJson
                {
                     BirthDay = itm.DateOfBirth.ToString(),
                     Breed = itm.HorseBreed.ToString(),
                     Breeder = itm.HorseBreeder.ToString(),
                     Name = itm.HorseName.ToString()
                });
            }

            return new Json(new { result = res});
        }

        [HttpGet]
        public ActionResult AddHorse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHorse(Horse horse)
        {
            if (horse != null)
            {
                var model = IHorseService.AddHorse(horse);
            }

            return RedirectToAction("GetHorses");
        }

        [HttpGet]
        public ActionResult DeleteHorse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteHorse(int HorseId)
        {
            var model = IHorseService.DeleteHorse(HorseId);

            return RedirectToAction("GetHorses");
        }

        [HttpGet]
        public IActionResult EditHorse(int HorseId)
        {
            var model = IHorseService.GetHorse(HorseId);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditHorse(int HorseId, Horse horse)
        {
            if(IHorseService.EditHorse(HorseId, horse))
            return RedirectToAction("GetHorses");

            return View(horse);
        }
    }
}