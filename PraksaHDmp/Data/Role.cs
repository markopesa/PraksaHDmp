namespace PraksaHDmp.Data
{
    public class Role : BaseClass
    {
        public string Name { get; set; }
        
        public int UserCreatedId { get; set; }
        public User UserCreated { get; set; }

        public int? UserModifiedId { get; set; }
        public User UserModified { get; set; }

       
        public ICollection<UserRole> UserRoles { get; set; }
    }

}
