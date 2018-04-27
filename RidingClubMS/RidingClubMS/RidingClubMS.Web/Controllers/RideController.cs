using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RidingClubMS.Services.Interfaces;
using RidingClubMS.BLL.Entities;
using RidingClubMS.ViewModels.RideViewModels;
using Microsoft.AspNetCore.Identity;

namespace RidingClubMS.Web.Controllers
{
    public class RideController : Controller
    {
        private readonly IRideService _IRideService;
        private readonly UserManager<ViewModels.RideViewModels.User> _userManager;

        public RideController(IRideService IRideService, UserManager<ViewModels.RideViewModels.User> userManager)
        {
            _IRideService = IRideService;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetRide(int RideId)
        {
            var model = _IRideService.GetRide(RideId);

            return View(model);
        }

        [HttpGet]
        public IActionResult GetRides()
        {
            var model = _IRideService.GetRides();

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
                var model = _IRideService.AddRide(ride);
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
            var model = _IRideService.DeleteRide(RideId);

            return RedirectToAction("GetRides");
        }

        [HttpGet]
        public IActionResult EditRide(int RideId)
        {
            var model = _IRideService.GetRide(RideId);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditRide(int RideId, Ride ride)
        {
            if (_IRideService.EditRide(RideId, ride))
                return RedirectToAction("GetRides");

            return View(ride);
        }

        [HttpGet]
        public async Task<IActionResult> RideReservation(int RideId, int UserId)
        {
            var model = new RideReservationViewModel()
            {
                User = await _userManager.FindByIdAsync(UserId.ToString()),
                UserId = UserId,
                Ride = _IRideService.GetRide(RideId),
                RideId = RideId
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult RideReservation(Ride ride, ViewModels.RideViewModels.User user)
        {
            if (ride != null && user != null)
            {
                var model = _IRideService.RideReservation(ride, user);
            }

            return RedirectToAction("GetRides");
        }
    }
}