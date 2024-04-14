namespace PraksaHDmp.Data
{
    public class Server : BaseClass
    {
        public Building Building { get; set; }
        public User User { get; set; }
        public string Name { get; set; }    
        public int BuildingId { get; set; }
        public int UserCreatedId { get; set; }  
        public int UserModifiedId { get; set;}


    }
}
