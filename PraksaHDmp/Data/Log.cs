namespace PraksaHDmp.Data
{
    public class Log : BaseClass
    {
        public User User { get; set; }
        public Application Application { get; set; }
        public int ApplicationId { get; set; }
        public string? Name { get; set; }
        public int UserCreatedId { get; set; }
        public int? UserModifiedId { get; set;}

    }
}
