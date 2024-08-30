namespace FinanceAPI.Infrastructure.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public static readonly Guid AdminUserId = Guid.NewGuid();
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var adminUser = new ApplicationUser
            {
                Id = AdminUserId,
                FirstName = "Admin",
                LastName = "User",
                Email = "admin@example.com",
                UserName = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = AdminUserId.ToString("D"),
                ProfilePicture=""
            };
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin@123");
            builder.HasData(adminUser);
        }
    }
}
