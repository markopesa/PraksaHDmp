namespace PraksaHDmp.Data
{
    public class Building : BaseClass
    {
        
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public Location Location { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; } 
    }
}
