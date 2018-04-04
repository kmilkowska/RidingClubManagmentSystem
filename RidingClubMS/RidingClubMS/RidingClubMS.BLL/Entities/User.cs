using Microsoft.AspNetCore.Identity;
using RidingClubMS.ViewModels;
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
        public bool IsEmployee { get; set; }

        public virtual ICollection<UserRide> UserRides { get; set; }
    }
}
