namespace PraksaHDmp.Data
{
    public class ApplicationUsage : BaseClass
    {
        public User User { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public int UserCreatedId { get; set; }
        public int UserModifiedId { get; set;}

        public bool Active { get; set; } = true;
    }
}
