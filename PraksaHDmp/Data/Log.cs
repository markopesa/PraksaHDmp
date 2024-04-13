namespace PraksaHDmp.Data
{
    public class Log
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserCreatedId { get; set; }
        public DateTime? DateModified { get; set; }
        public int? UserModifiedId { get; set; }
    }
}
