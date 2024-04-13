namespace PraksaHDmp.Data
{
    public class Building : BaseClass
    {
        public Location Location { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; } 
        public int UserCreatedId { get; set; }  
        public int UserModifiedId { get; set;}
    }
}
