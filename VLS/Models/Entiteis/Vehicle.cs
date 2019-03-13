using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VLS.Models.Entiteis
{
    public class Vehicle
    {

        public int VehicleId { get; set; }
        [Required(ErrorMessage = "لطفا نام وسیله نقلیه را وارد نمایید!")]
        [Display(Name = "نام وسیله نقلیه  ")]
        public string VehicleName { get; set; }
        [Required(ErrorMessage = "لطفا شماره پلاک را وارد نمایید!")]
        [Display(Name = "شماره پلاک ")]
        public string VehicleNo { get; set; }
        [Required(ErrorMessage = "لطفا شماره سیم کارت ثبت شده  را وارد نمایید!")]
        [Display(Name = "شماره سیم کارت ")]
        public string SimcardNo { get; set; }
        [Required(ErrorMessage = "لطفا شماره هسریال را وارد نمایید!")]
        [Display(Name = "نام ")]
        public string Imei { get; set; }
        public virtual Customer Customers { get; set; }
        [Required(ErrorMessage = "لطفا کاربری را مشخص نمایید!")]
        [Display(Name = "کاربری ")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "لطفا نام راننده را وارد نمایید!")]
        [Display(Name = "نام راننده ")]
        public int DriverName { get; set; }
        [Required(ErrorMessage = "لطفا آدرس راننده را وارد نمایید!")]
        [Display(Name = "آدرس راننده ")]
        public string DriverAddress { get; set; }
        [Required(ErrorMessage = "لطفاشماره تلفن راننده را وارد نمایید!")]
        [Display(Name = "شروع بیمه نامه ")]
        public string DriverPhoneNo { get; set; }
       
        [Display(Name = "شروع بیمه نامه ")]
        public DateTime PolicyStartDate { get; set; }
        [Display(Name = "پایان بیمه نامه ")]
        public DateTime PolicyEndDate { get; set; }
        [Display(Name = "تصویر راننده ")]
        public byte[] DriverImage { get; set; }

        [Required(ErrorMessage = "لطفاتاریخ نصب دستگاه را وارد نمایید!")]
        [Display(Name = "تاریخ نصب دستگاه ")]
        public DateTime RegisterDate { get; set; }
        [Required(ErrorMessage = "لطفاتاریخ پایان دستگاه را وارد نمایید!")]
        [Display(Name = "تاریخ پایان دستگاه ")]
        public DateTime ExpireDate { get; set; }
        [Required(ErrorMessage = "لطفا نوع وسیله نقلیه را وارد نمایید!")]
        [Display(Name = "نوع وسیله نقلیه ")]
        public int TypeId { get; set; }
        [ForeignKey("TypeId ")]
        public virtual Vehicletype vehichtype { get; set; }
        public virtual ICollection<GpsData> Gpsdatas { get; set; }
      
       

       
    }
}