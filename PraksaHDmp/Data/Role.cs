using System.ComponentModel.DataAnnotations;

namespace PraksaHDmp.Data
{
    public class Role : BaseClass
    {
        
        public string Name { get; set; }       
        public ICollection<UserRole> UserRoles { get; set; }
    }

}
