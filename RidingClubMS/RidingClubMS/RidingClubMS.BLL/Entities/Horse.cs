using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RidingClubMS.BLL.Entities
{
    public class Horse
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
        [Required]
        public string HorseOwner { get; set; }
        [Required]
        public string ImgUrl { get; set; }
       
    }
}
