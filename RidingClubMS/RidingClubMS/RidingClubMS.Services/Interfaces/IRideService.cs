
using RidingClubMS.BLL.Entities;
using RidingClubMS.ViewModels.RideViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RidingClubMS.Services.Interfaces
{
    public interface IRideService
    {
        List<Ride> GetRides();
        Ride GetRide(int RideId);
        bool AddRide(Ride ride);
        bool EditRide(int RideId, Ride ride);
        bool DeleteRide(int RideId);
        List<UserRide> GetUsers(int RideId);
        bool RideReservation(Ride ride, ViewModels.RideViewModels.User user);
    }
}
