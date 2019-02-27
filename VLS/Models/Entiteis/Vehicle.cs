using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLS.Models.Entiteis
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public string VehicleName { get; set; }
        public string VehicleNo { get; set; }
        public virtual Customer Customers { get; set; }
        public int CustomerId { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId ")]
        public virtual Vehicletype vehichtype { get; set; }
        public virtual ICollection<GpsData> Gpsdatas { get; set; }
      
       

       
    }
}