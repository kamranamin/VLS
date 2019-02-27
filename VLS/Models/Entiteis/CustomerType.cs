using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VLS.Models.Entiteis
{
    public class CustomerType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }

       
    }
}