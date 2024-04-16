namespace PraksaHDmp.Data
{
    public class Location : BaseClass
    {
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public Department Department { get; set; }
        public string Name { get; set; }    
        public int DepartmentId { get; set; }
    }
}
