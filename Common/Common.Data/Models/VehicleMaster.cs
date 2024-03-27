using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Models
{
    public  class VehicleMaster : BaseModels
    {
        public string? Make { get; set; }
        public string? Name { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        public string? ImageUrl { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? VIN { get; set; }
        public string? LicensePlate { get; set; }
        public string? Color { get; set; }
        public int? OwnerID { get; set; }



    }

}
