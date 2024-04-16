using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public abstract class BaseClass
    {
        public User UserCreated { get; set; }
        public User? UserModified { get; set; }
        public int Id { get; set; }
        public bool Active { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime DateCreated { get; set; }


    }
}
