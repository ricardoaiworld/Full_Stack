using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class ClientDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phones { get; set; }
        public string Address { get; set; }
        public DateTime AddedOn { get; set; }

        public List<InteractionCardResponseModel> Interactions { get; set; }
    }
}
