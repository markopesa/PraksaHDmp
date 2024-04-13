namespace PraksaHDmp.Data
{
    public class Department : BaseClass
    {
        public string Name { get; set; }

        public User User { get; set; }

        public int UserCreatedId { get; set; }
        public int UserModifiedId { get; set;}

        
    }
}
