using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RidingClubMS.DAL.Models
{
    public class Rides
    {
        [Key]
        public int RideId { get; set; }
        public int TrainerId { get; set; }
        public DateTime RideDate { get; set; }
        public string RideTime { get; set; }
        public int AvailablePlaces { get; set; }
        public string AdvanceLevel { get; set; }
    }
}
