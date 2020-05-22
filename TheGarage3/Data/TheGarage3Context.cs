using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheGarage3.Models;

namespace TheGarage3.Data
{
    public class TheGarage3Context : DbContext
    {
        public TheGarage3Context (DbContextOptions<TheGarage3Context> options)
            : base(options)
        {
        }

        public DbSet<TheGarage3.Models.ParkedVehicle> ParkedVehicle { get; set; }
        public DbSet<TheGarage3.Models.Member> Member { get; set; }
        public DbSet<TheGarage3.Models.VehicleType> VehicleType { get; set; }
    }
}
