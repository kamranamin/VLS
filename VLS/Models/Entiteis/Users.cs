using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VLS.Models.Entiteis
{
    public class Users
	{ 
        public int Id { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string Company { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}