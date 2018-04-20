using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RidingClubMS.Services.Interfaces;
using RidingClubMS.BLL.Entities;

namespace RidingClubMS.Web.Controllers
{
    public class RideController : Controller
    {
        private readonly IRideService IRideService;

        public RideController(IRideService _IRideService)
        {
            IRideService = _IRideService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetRide(int RideId)
        {
            var model = IRideService.GetRide(RideId);

            return View(model);
        }

        [HttpGet]
        public IActionResult GetRides()
        {
            var model = IRideService.GetRides();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddRide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRide(Ride ride)
        {
            if (ride != null)
            {
                var model = IRideService.AddRide(ride);
            }

            return RedirectToAction("GetRides");
        }

        [HttpGet]
        public IActionResult DeleteRide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteRide(int RideId)
        {
            var model = IRideService.DeleteRide(RideId);

            return RedirectToAction("GetRides");
        }

        [HttpGet]
        public IActionResult EditRide(int RideId)
        {
            var model = IRideService.GetRide(RideId);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditRide(int RideId, Ride ride)
        {
            if (IRideService.EditRide(RideId, ride))
                return RedirectToAction("GetRides");

            return View(ride);
        }
    }
}