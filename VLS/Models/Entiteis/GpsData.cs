using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLS.Models.Entiteis
{
    public class GpsData
    {
        public Int64 Id { get; set; }
       
       
        public int vehId { get; set; }
        [ForeignKey("vehId")]
        public virtual Vehicle Vehiche { get; set; }

        public int MyProperty { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public int Speed { get; set; }
        public int Angle { get; set; }
        public int Locate { get; set; }
        public DateTime Atime { get; set; }
        public int Mileage { get; set; }
        public int Temperature { get; set; }
       
    }
}