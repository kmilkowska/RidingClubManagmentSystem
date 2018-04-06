using RidingClubMS.BLL.Entities;
using RidingClubMS.DAL.EF;
using RidingClubMS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RidingClubMS.Services.Services
{
    public class HorseService : IHorseService
    {
        ApplicationDbContext<User, Role, int> ctx;

        public HorseService(ApplicationDbContext<User, Role, int> db)
        {
            this.ctx = db;
        }

        public bool AddHorse(Horse horse)
        {
            try
            {
                ctx.Horses.Add(horse);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHorse(int HorseId)
        {
            try
            {
                var horse = GetHorse(HorseId);
                ctx.Remove(horse);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditHorse(int HorseId, Horse horse)
        {
            try
            {
                var oldHorse = GetHorse(HorseId);
                oldHorse.HorseId = horse.HorseId;
                oldHorse.HorseBreed = horse.HorseBreed;
                oldHorse.HorseBreeder = horse.HorseBreeder;
                oldHorse.HorseCoulour = horse.HorseCoulour;
                oldHorse.HorseDam = horse.HorseDam;
                oldHorse.HorseDescription = horse.HorseDescription;
                oldHorse.HorseName = horse.HorseName;
                oldHorse.HorseOwner = horse.HorseOwner;
                oldHorse.HorseSex = horse.HorseSex;
                oldHorse.HorseSire = horse.HorseSire;
                oldHorse.ImgUrl = horse.ImgUrl;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Horse GetHorse(int HorseId)
        {
            try
            {
                return ctx.Horses.Single(x => x.HorseId == HorseId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Horse> GetHorses()
        {
            try
            {
                return ctx.Horses.ToList();
            }
            catch (Exception)
            {
                return new List<Horse>();
            }
        }

        public List<Horse> GetHorsesByBreed(string HorseBreed)
        {
            try
            {
                return ctx.Horses.Where(x => x.HorseBreed == HorseBreed).ToList();
            }
            catch (Exception)
            {
                return new List<Horse>();
            }
        }
    }
}
