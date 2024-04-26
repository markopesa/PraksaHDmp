using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class User 
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; } 
        public DateTime? LastLogin { get; set; }
        [ForeignKey("UserCreatedId")]
        public int UserCreatedId { get; set; }
        
        public User UserCreated { get; set; }

        [ForeignKey("UserModifiedId")]
        public int? UserModifiedId { get; set; }
        
        public User? UserModified { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }

}
