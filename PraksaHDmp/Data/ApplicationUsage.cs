namespace PraksaHDmp.Data
{
    public class ApplicationUsage : BaseClass
    {

        public User UserCreated { get; set; } 
        public User UserModified { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; } = true;
    }
}
