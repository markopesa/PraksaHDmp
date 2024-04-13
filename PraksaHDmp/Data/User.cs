using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class User : BaseClass
    {
  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; } 
        public DateTime? LastLogin { get; set; }
        public int UserCreatedId { get; set; }
        [ForeignKey(nameof(UserCreatedId))]
        public User UserCreated { get; set; }
      
        public int? UserModifiedId { get; set; }
        [ForeignKey(nameof(UserModifiedId))]
        public User UserModified { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }

}
