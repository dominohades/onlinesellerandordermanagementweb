using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

 namespace MvcLoginRegistration.Models
{
    public class UserAccount
    {
        [Key]
        [Required(ErrorMessage = "FirstName is Required ")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "FirstName is Required ")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required ")]

        public string Email { get; set; }

        [Required(ErrorMessage = "UserName is Required ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


      
        

        [Compare("Password", ErrorMessage = "Please Confirm your Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword{ get; set; }


        


    }
}