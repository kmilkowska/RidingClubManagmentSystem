using RidingClubMS.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RidingClubMS.Services.Interfaces
{
    public interface IHorseService
    {
        List<Horse> GetHorses();
        List<Horse> GetHorsesByBreed(string HorseBreed);
        Horse GetHorse(int HorseId);
        bool AddHorse(Horse horse);
        bool EditHorse(int HorseId, Horse horse);
        bool DeleteHorse(int HorseId);

    }
}
