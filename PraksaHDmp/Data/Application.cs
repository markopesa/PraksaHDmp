namespace PraksaHDmp.Data
{
    public class Application : BaseClass
    {
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public ApplicationUsage ApplicationUsage { get; set; }
        public Server Server { get; set; }
        public Employee Employee { get; set; }
        public string Name { get; set; }
        public string? Version { get; set; }
        public int? ResponsibleEmployeeId { get; set; }  
        public int? NumberOfUsers { get; set; }
        public string? Author { get; set; }
        public bool? Maintence {  get; set; }
        public DateTime? MaintenceExpiration { get; set; }
        public int? ApplicationUsageId { get; set; }
        public int? ServerId { get; set; }
        public string? Description { get; set; }
        public string? Contact { get; set; }
        public string? ContactPhone { get; set; }

       
    }
}
