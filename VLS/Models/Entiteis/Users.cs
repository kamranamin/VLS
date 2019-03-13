using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VLS.Models.Entiteis
{
    public class Users
	{ 
        
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفا !")]
        [Display(Name = "نام کاربری  ")]
        public string Username { get; set; }
         [DataType(DataType.Password)]
          [Display(Name = "رمز عبور")]
         public string Password { get; set; }
        
       
        
     
       public DateTime RegisterDate { get; set; }
        

    }
}