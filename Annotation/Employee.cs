using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public class Employee
    {
      [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
      [Required(ErrorMessage = "Employee Age is required")]
        [Range(18, 99, ErrorMessage = "Age should be above 18")]
        public int Age { get; set; }
      [Required(ErrorMessage = "Employee Phone is required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
      [Required(ErrorMessage = "Employee Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
