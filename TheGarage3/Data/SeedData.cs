using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGarage3.Models;

namespace TheGarage3.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider services)
        {
            var option = services.GetRequiredService<DbContextOptions<TheGarage3Context>>();
            using (var context = new TheGarage3Context(option))
            { var fake = new Faker("sv");
                var vehicles = new List<VehicleType>();
                if (context.VehicleType.Any())
                {

                }
                else
                {
                    for(int i = 0; i<5; i++)
                    {
                        var ftype = fake.Vehicle.Type();
                        var vehicletype = new VehicleType
                        {
                            TypeofVehicle = ftype,
                        };
                    vehicles.Add(vehicletype);

                    }
                context.AddRange(vehicles);
                context.SaveChanges();
                }
            }
        }
    }
}
