using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "58b9fee9-333f-4278-a792-53860fd0b7ca",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    ConcurrencyStamp = "c87b586b-a804-4b71-b671-fc6daac9d338"
                },
                new IdentityRole
                {
                    Id = "17d7d0e7-71b9-47a7-a0bb-aaa7318476f3",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR",
                    ConcurrencyStamp = "978a19be-b7c8-42d1-b3cb-8fb19e6f8756"
                },
                new IdentityRole
                {
                    Id = "b29fe88e-ed6d-4359-b82c-5953425ab3e1",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = "8ff85667-fe7f-4c9d-a30f-28ce536dbd27"
                });

            builder.Entity<IdentityUser>()
                .HasData(new IdentityUser
                {
                    Id = "b29fe88e-ed6d-4359-b82c-5953425ab3e1",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = "AQAAAAIAAYagAAAAEBhz8hHaAbCMu0ILuGwNqLPqLPH8hj5qXqCqN3qL0wZYTwVfOPfL2qN2JIQH3UM8Fg==",
                    EmailConfirmed = true,
                    ConcurrencyStamp = "a078cae8-0de7-4207-8094-9c133a0a2231",
                    SecurityStamp = "e2307f74-c8b6-4b6e-898e-54214ab6abc1"
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b29fe88e-ed6d-4359-b82c-5953425ab3e1",
                    UserId = "b29fe88e-ed6d-4359-b82c-5953425ab3e1"
                });
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
    
}
