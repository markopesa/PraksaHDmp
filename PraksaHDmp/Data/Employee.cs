namespace PraksaHDmp.Data
{
    public class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User UserCreated { get; set; }
        public User? UserModified { get; set; }
        public int Id { get; set; }
        public bool Active { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
