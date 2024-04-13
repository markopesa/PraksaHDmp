namespace PraksaHDmp.Data
{
    public class UserRole 
    {
        public bool? Active { get; set; }

     
        public int UserId { get; set; }
        public User User { get; set; }

        
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }

}
