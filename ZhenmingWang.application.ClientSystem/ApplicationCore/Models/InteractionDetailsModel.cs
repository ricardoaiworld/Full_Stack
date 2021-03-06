using System;
namespace ApplicationCore.Models
{
    public class InteractionDetailsModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmpId { get; set; }
        public char IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }
        public string ClientName { get; set; }
        public string EmpName { get; set; }
    }
}
