﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VLS.Models.Entiteis
{
    public class GpsData
    {
        public Int64 Id { get; set; }
        [Display(Name ="Header")]
        public byte Header { get; set; }
        public string  Lenght { get; set; }
        public string   Imei { get; set; }
        [ForeignKey("Imei")]
        public virtual Vehicle Vehiche { get; set; }

        public string  VehicleStatus { get; set; }
        public string  DateTime { get; set; }
        public string BatteryVoltage { get; set; }
        public string SuplayVoltage { get; set; }
        public string Adc1 { get; set; }
         public string Adc2 { get; set; }
        public string Adc3 { get; set; }
        public string Adc4 { get; set; }
        public string  TemperatureA { get; set; }
        public string TemperatureB { get; set; }
        public string LACCI { get; set; }
        public string CellId { get; set; }
        public string GPSSatellites { get; set; }
        public string GSMsignal { get; set; }
        public int Angle { get; set; }
        public int Speed { get; set; }
        public string HDOP { get; set; }
        public int Mileage { get; set; }
        public float Latitude { get; set; }

        public string NS { get; set; }
        public float Longitude { get; set; }
        public string EW { get; set; }
        public string SerialNumber { get; set; }
        public string Checksum { get; set; }






    }
}