namespace PraksaHDmp.Data
{
    public class Employee : BaseClass
    {
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
