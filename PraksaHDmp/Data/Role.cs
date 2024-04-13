namespace PraksaHDmp.Data
{
    public class Role
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        
        public int UserCreatedId { get; set; }
        public User UserCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public int? UserModifiedId { get; set; }
        public User UserModified { get; set; }

       
        public ICollection<UserRole> UserRoles { get; set; }
    }

}
