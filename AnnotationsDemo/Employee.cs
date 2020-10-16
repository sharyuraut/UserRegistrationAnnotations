using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnnotationsDemo
{
    class Employee
    {
        [RegularExpression("^[A-Z][a-z]+$")]
        [Required (ErrorMessage ="Employee {0} is required")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Name should be minimum 3 characters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }


        [RegularExpression("^[A-Z][a-z]+$")]
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be minimum 3 characters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }


        [RegularExpression("^[0-9]{2}$")]
        [Range(18, 99, ErrorMessage ="Age should be above 18 and below 99")]
        public int Age { get; set; }

        [RegularExpression("^[+][1-9][0-9]+[1-9][0-9]{9}$")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Proper format should be present in password!")]
        [PasswordPropertyText]
        public string password { get; set; }
    }
}
