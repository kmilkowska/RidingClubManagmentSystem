using RidingClubMS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using RidingClubMS.BLL.Entities;
using RidingClubMS.DAL.EF;
using System.Linq;

namespace RidingClubMS.Services.Services
{
    public class RideService : IRideService
    {
        ApplicationDbContext<User, Role, int> ctx;

        public RideService(ApplicationDbContext<User, Role, int> db)
        {
            this.ctx = db;
        }

        public bool AddRide(Ride ride)
        {
            try
            {
                ctx.Rides.Add(ride);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRide(int RideId)
        {
            try
            {
                var ride = GetRide(RideId);
                ctx.Remove(ride);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditRide(int RideId, Ride ride)
        {

            try
            {
                var oldRide = GetRide(RideId);
                oldRide.RideId = ride.RideId;
                oldRide.AdvanceLevel = ride.AdvanceLevel;
                oldRide.AvailablePlaces = ride.AvailablePlaces;
                oldRide.RideDate = ride.RideDate;
                oldRide.RideTime = ride.RideTime;
                oldRide.Trainer = ride.Trainer;
               
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Ride GetRide(int RideId)
        {
            try
            {
                return ctx.Rides.Single(x => x.RideId == RideId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Ride> GetRides()
        {
            try
            {
                return ctx.Rides.ToList();
            }
            catch (Exception)
            {
                return new List<Ride>();
            }
        }

        public List<UserRide> GetUsers(int RideId)
        {

            try
            {
                return ctx.UserRides.Where(x => x.RideId == RideId).ToList();
            }
            catch (Exception)
            {
                return new List<UserRide>();
            }
        }

        public bool RideReservation(Ride ride, User user)
        {
            try
            {
                var itm = new UserRide()
                {
                    Ride = ride,
                    RideId = ride.RideId,
                    User = user,
                    UserId = user.Id
                };
                ctx.UserRides.Add(itm);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
