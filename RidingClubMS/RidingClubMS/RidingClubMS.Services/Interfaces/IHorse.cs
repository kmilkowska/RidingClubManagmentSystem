using RidingClubMS.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RidingClubMS.Services.Interfaces
{
    public interface IHorse
    {
        List<Horse> GetHorses();
        List<Horse> GetHorsesByBreed(string HorseBreed);
        Horse GetHorse(int HorseId);
        bool AddHorse(Horse horse);
        bool EditHorse(int HorseId);
        bool DeleteHorse(int HorseId);

    }
}
