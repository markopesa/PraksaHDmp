using System.ComponentModel.DataAnnotations;

namespace PraksaHDmp.Models
{
    public class UserEditVM
    {
        public int Id { get; set; }
        [Display(Name = "Datum modificiranja")]
        public DateTime DateModified { get; set; }
        [Display(Name = "Datum kreiranja")]
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
