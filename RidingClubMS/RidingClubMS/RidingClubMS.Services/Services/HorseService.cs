using RidingClubMS.BLL.Entities;
using RidingClubMS.DAL.EF;
using RidingClubMS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RidingClubMS.Services.Services
{
    public class HorseService : IHorse
    {
        ApplicationDbContext<User, Role, int> ctx;

        public HorseService(ApplicationDbContext<User, Role, int> db)
        {
            this.ctx = db;
        }

        public bool AddHorse(Horse horse)
        {
            throw new NotImplementedException();
        }

        public bool DeleteHorse(int HorseId)
        {
            throw new NotImplementedException();
        }

        public bool EditHorse(int HorseId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Horse> GetHorsesByBreed(string HorseBreed)
        {
            throw new NotImplementedException();
        }
    }
}
