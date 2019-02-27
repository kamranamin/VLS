using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLS.Models.Entiteis
{
	public class Customer
	{

		public int Id { get; set; }

		[Required(ErrorMessage = "لطفا نام را وارد نمایید!")]
		[Display(Name = "نام ")]
		public string FullName { get; set; }

		[Required(ErrorMessage = "لطفا ایمیل را وارد نمایید!")]
		[Display(Name = "ایمیل")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "لطفا آدرس را وارد نمایید!")]
		[Display(Name = "آدرس")]
		public string Address { get; set; }

		[Display(Name = "شماره تماس")]
		[DataType(DataType.PhoneNumber)]
		public string Tel { get; set; }

		[Display(Name = "نوع مشتری")]
		public int TypeId { get; set; }

		[ForeignKey("TypeId")]
		public virtual CustomerType CusomerType { get; set; }

		public virtual ICollection<Vehicle> vehicles { get; set; }

	}

}