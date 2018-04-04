using System;
using System.Collections.Generic;
using System.Text;

namespace RidingClubMS.BLL.Entities
{
    public class UserRide
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RideId { get; set; }
        public Ride Ride { get; set; }
    }
}
