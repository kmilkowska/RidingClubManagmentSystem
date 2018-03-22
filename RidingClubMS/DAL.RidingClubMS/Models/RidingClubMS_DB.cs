using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RidingClubMS.DAL.Models
{
    public class RidingClubMS_DB: DbContext
    {
        public RidingClubMS_DB(DbContextOptions<RidingClubMS_DB>options): base(options) { }

        public DbSet<Horses> Horses { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rides> Rides { get; set; }
    }
}
