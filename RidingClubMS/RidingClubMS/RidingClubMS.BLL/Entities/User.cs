﻿using Microsoft.AspNetCore.Identity;
using RidingClubMS.BLL.Entities;
using System.Collections.Generic;

namespace RidingClubMS.BLL.Entities
{
    public class User : IdentityUser<int>
    {
        //public User()
        //{
        //    this.UserRides = new HashSet<Ride>();
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserRide> UserRides { get; set; }
    }
}
