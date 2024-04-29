using PraksaHDmp.Data;
using System.ComponentModel.DataAnnotations;

namespace PraksaHDmp.Models
{
    public class UserInactiveVM
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        [Display(Name = "Username")]
        public string Username { get; set; }

        public List<User> InactiveUsers { get; set; }
    }
}
