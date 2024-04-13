namespace PraksaHDmp.Data
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime DateCreated { get; set; }


    }
}
