using RidingClubMS.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RidingClubMS.BLL.Entities
{
    public class Ride
    {
        //public Ride()
        //{
        //    this.Users = new HashSet<User>();
        //}

        [Key]
        public int RideId { get; set; }
        [Required]
        public int TrainerId { get; set; }
        [Required]
        public DateTime RideDate { get; set; }
        [Required]
        public string RideTime { get; set; }
        [Required]
        public int AvailablePlaces { get; set; }
        [Required]
        public string AdvanceLevel { get; set; }

        public virtual ICollection<UserRide> Users { get; set; }
    }
}
