using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class EmployeeAddRequestModel
    {

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }


    }
}