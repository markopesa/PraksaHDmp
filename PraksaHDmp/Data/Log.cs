namespace PraksaHDmp.Data
{
    public class Log : BaseClass
    {
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public Application Application { get; set; }
        public int ApplicationId { get; set; }
        public string? Name { get; set; }

    }
}
