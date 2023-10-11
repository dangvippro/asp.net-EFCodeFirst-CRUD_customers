using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MidTerm.Models
{
    public class Customer
    {
        [Key]
        [Display(Name= "ID")]
        public string id { get; set; }

        
        [Display(Name= "Fullname")]
        [Required(ErrorMessage = "Fullname cannot be blank")]
        public string fullname { get; set; }

        
        [Display(Name= "Birthday")]
        [DisplayFormat(DataFormatString = "[0: dd/MM/yyyy]")]
        [Required(ErrorMessage = "Birthday cannot be blank")]
        public System.DateTime birthday { get; set; }

        
        [Display(Name= "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string gender { get; set; }

        
        [Display(Name= "Email")]
        [Required(ErrorMessage = "Email cannot be blank")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        
        [Display(Name= "Phone")]
        [Required(ErrorMessage = "Phone cannot be blank")]
        public string phone { get; set; }

        
        [Display(Name= "Address")]
        [Required(ErrorMessage = "Address cannot be blank")]
        public string address { get; set; }
    }
}