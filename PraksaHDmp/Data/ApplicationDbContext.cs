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
        public DbSet<DeviceServer> DeviceServers { get; set; }  
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }  
        public DbSet<RAMType> RAMTypes { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Photo> Photos { get; set; }   
        public DbSet<Multifunctional> Multifunctionals { get; set; }
        public DbSet<Other> Others { get; set; }
        public DbSet<HDDSpeed> HDDSpeeds { get; set; }
        public DbSet<Scanner> Scanners { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<DocumentLog> DocumentLogs { get; set; }
        public DbSet<MobileDevice> MobileDevices { get; set; }
        public DbSet<Monitor> Monitors { get; set; }

        
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
