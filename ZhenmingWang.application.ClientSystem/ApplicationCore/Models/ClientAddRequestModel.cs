using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class ClientAddRequestModel
    {

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Phones { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

    }
}