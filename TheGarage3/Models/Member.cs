using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGarage3.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}
