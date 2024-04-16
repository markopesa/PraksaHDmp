namespace PraksaHDmp.Data
{
    public class Role : BaseClass
    {
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public string Name { get; set; }       
        public ICollection<UserRole> UserRoles { get; set; }
    }

}
