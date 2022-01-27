using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]

        [Required(ErrorMessage = "Required")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Required")]
        public String FName { get; set; }
        
        [Required(ErrorMessage = "Required")]
        public String LName { get; set; }
        
        [Required(ErrorMessage = "Required")]
        public String Email { get; set; }
        
        [Required(ErrorMessage = "Required")]
        public String Password { get; set; }
        
        [Required(ErrorMessage = "Required")]
        public String Mobile { get; set; }
        
        [Required(ErrorMessage = "Required")]
        public String Gender { get; set; }
        public String Experience { get; set; }
        
        [NotMapped]
        public String Department { get; set; }
    }
}
