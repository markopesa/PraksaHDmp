using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Employee : IdentityUser
    {
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        public User UserCreated { get; set; }
        public User? UserModified { get; set; }
        public int Id { get; set; }
        public bool Active { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
