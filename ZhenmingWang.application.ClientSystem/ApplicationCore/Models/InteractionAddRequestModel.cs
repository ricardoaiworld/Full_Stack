using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class InteractionAddRequestModel
    {

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int EmpId { get; set; }

        [Required]
        public char IntType { get; set; }

        [Required]
        public DateTime IntDate { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarks { get; set; }

    }
}