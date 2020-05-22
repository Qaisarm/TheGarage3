using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGarage3.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }

        public int MemberId { get; set; }
        public DateTime CheckInTime { get; set; }
       

        //Navigationproperty Not in database!
        public Member Member { get; set; }
    }
}
