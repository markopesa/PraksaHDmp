using System.ComponentModel.DataAnnotations;

namespace PraksaHDmp.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Display(Name = "E-mail")]
        public string Mail { get; set; }

    }
}
