using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AnnotationsDemo
{
    class AnnotationsTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class Validation: ");

            Employee objectEmployee = new Employee();
            objectEmployee.FirstName = "Sharyu";
            objectEmployee.LastName = "Raut";
            objectEmployee.Age = 19;
            objectEmployee.PhoneNumber = "+919876543210";
            objectEmployee.Email = "abc.xyz@gmail.com";
            objectEmployee.password = "Sharyu#1243";

            ValidationContext context = new ValidationContext(objectEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objectEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Member Name: {0} ", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error message: {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("First Name: " + objectEmployee.FirstName + "Last Name: " + objectEmployee.LastName + "\n" + "Age: " + objectEmployee.Age + "\n" + "Phone Number: " + objectEmployee.PhoneNumber + "\n" + "Email: "+ objectEmployee.Email + "\n" + "Password: " + objectEmployee.password);
            }

            Console.WriteLine("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}
