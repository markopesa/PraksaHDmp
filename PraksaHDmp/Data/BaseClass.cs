namespace PraksaHDmp.Data
{
    public abstract class BaseClass
    {
        public User User { get; set; }
        public int UserCreatedId { get; set; }
        public int? UserModifiedId { get; set; }
        public int Id { get; set; }
        public bool Active { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime DateCreated { get; set; }


    }
}
