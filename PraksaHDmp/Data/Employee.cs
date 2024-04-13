namespace PraksaHDmp.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserCreatedId { get; set; }
        public DateTime? DateModified { get; set; }
        public int? UserModifiedId { get; set; }

        public User User { get; set; }
    }
}
