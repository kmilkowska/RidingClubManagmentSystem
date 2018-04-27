using RidingClubMS.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RidingClubMS.ViewModels.RideViewModels
{
    public class RideReservationViewModel
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RideId { get; set; }
        public Ride Ride { get; set; }
    }
}
