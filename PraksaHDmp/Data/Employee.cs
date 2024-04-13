namespace PraksaHDmp.Data
{
    public class Employee : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserCreatedId { get; set; }
        public int? UserModifiedId { get; set; }

        public User User { get; set; }
    }
}
