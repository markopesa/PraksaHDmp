using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PraksaHDmp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRoles {  get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<ApplicationUsage> ApplicationUsages { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<ComputerOS> ComputerOsses { get; set; }
        public DbSet<County> Counties { get; set; } 
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<DeviceStateNew> DeviceStatesNew { get; set; }
        public DbSet<HDDType> HDDTypes { get; set; }
        public DbSet<MonitorResolution> MonitorResolutions { get; set; }
        public DbSet<MonitorFormat> MonitorFormats { get; set; }
        public DbSet<MobileDeviceType> MobileDeviceTypes { get; set; }
        public DbSet<MonitorSize> MonitorSizes { get; set; }
        public DbSet<MonitorType> MonitorTypes { get; set; }
        public DbSet<PartnerContactType> PartnerContactTypes { get; set; }
        public DbSet<PrinterType> PrinterTypes { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserCreated)
                .WithMany()
                .HasForeignKey(u => u.UserCreatedId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserModified)
                .WithMany()
                .HasForeignKey(u => u.UserModifiedId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
