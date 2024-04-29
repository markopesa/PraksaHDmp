using System.ComponentModel.DataAnnotations;

namespace PraksaHDmp.Models
{
    public class UserCreateVM
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Ime")]
        public string FirstName { get; set; }
        [Display(Name = "Prezime")]
        public string LastName { get; set; }
        [Display(Name = "Korisničko ime")]
        public string Username { get; set; }
        [Display(Name = "E-mail")]
        public string Mail { get; set; }
    }
}
