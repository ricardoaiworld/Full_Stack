using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class EmployeeDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }

        public List<InteractionCardResponseModel> Interactions { get; set; }
    }
}
