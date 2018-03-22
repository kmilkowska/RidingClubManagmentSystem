using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RidingClubMS.DAL.Models
{
    public class Horses
    {
        [Key]
        public int HorseId { get; set; }
        [Required]
        public string HorseName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string HorseBreed { get; set; }
        [Required]
        public string HorseSex { get; set; }
        [Required]
        public string HorseCoulour { get; set; }
        [Required]
        public string HorseSire { get; set; }
        [Required]
        public string HorseDam { get; set; }
        [Required]
        public string HorseBreeder { get; set; }
        [Required]
        public string HorseDescription { get; set; }
        
        /*imageurl*/
    }
}
