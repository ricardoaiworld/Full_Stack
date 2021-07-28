using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Employee
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }

        //navigation properities
        public ICollection<Interaction> Interactions { get; set; }
    }
}
