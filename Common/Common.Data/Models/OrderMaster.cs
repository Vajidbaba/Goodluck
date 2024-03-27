using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Models
{
    public  class OrderMaster : BaseModels
    {
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserMobile { get; set; }
        public string? DriverName { get; set; }
        public string? DriverMobile { get; set; }
        public string? PickUpPoint { get; set; }
        public string? DropPoint { get; set; }
        public DateTime? EstimateDropDate { get; set; }
        public string? VehicleNumber { get; set; }
        public string? VehicleName { get; set; }
        public string? ItemName { get; set; }
        public string? ItemSize { get; set; }
        public string? ItemQuantity { get; set; }
        public string? Status { get; set; }
    }

}
