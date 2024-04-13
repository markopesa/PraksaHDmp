namespace PraksaHDmp.Data
{
    public class UserRole 
    {
        public Role Role { get; set; }
        public User User { get; set; }
        public bool? Active { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        
    }

}
