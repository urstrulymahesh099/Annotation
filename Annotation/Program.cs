using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    class Program
    {
        public static void Display()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("********Employee class Validation*********");
            Console.ForegroundColor = ConsoleColor.Red;
            Employee objEmployee = new Employee();
            objEmployee.Name = "Mahesh";
            objEmployee.Age = 23;
            objEmployee.PhoneNumber = "7829303710";
            objEmployee.Email = "maheshhonnamurthy@gmail.com";

            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name + "\n" + "Age: " + objEmployee.Age + "\n" + "PhoneNumber: " + objEmployee.PhoneNumber + "\n" + "Email: " + objEmployee.Email);
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            Program.Display();
        }
    }
}