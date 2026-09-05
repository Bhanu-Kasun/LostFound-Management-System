using System;
namespace Lost_And_Found_System.Models
{
    public class LostItem
    {
        public string ReportId { get; set; }
        public string UserId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime DateLost { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
    }
}
