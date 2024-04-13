namespace PraksaHDmp.Data
{
    public class Location : BaseClass
    {
        public Department Department { get; set; }
        public User User { get; set; }
        public string Name { get; set; }    
        public int DepartmentId { get; set; }
        public int UserCreatedId { get; set; }  
        public int UserModifiedId { get; set;}
    }
}
