using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Interaction
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmpId { get; set; }
        public char IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }


        //Navigation Properities
        public Client Client { get; set; }
        public Employee Employee { get; set; }
    }
}
