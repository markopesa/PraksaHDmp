using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Application : BaseClass
    {
        
        public ApplicationUsage ApplicationUsage { get; set; }
        public Server Server { get; set; }
        public Employee Employee { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string? Version { get; set; }
        public int? ResponsibleEmployeeId { get; set; }  
        public int? NumberOfUsers { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Author { get; set; }
        public bool? Maintence {  get; set; }
        public DateTime? MaintenceExpiration { get; set; }
        public int? ApplicationUsageId { get; set; }
        public int? ServerId { get; set; }
        [Column(TypeName = "nvarchar(2000)")]
        public string? Description { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string? Contact { get; set; }
        [Column(TypeName = "nchar(15)")]
        public string? ContactPhone { get; set; }

       
    }
}
