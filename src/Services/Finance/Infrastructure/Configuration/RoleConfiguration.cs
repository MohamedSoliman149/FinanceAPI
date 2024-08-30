namespace FinanceAPI.Infrastructure.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public static readonly Guid AdminRoleId = Guid.NewGuid();
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityRole<Guid>
                {
                    Id = AdminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}
