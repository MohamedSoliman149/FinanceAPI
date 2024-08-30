using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceAPI.Infrastructure.Configuration
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            builder.HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = ApplicationUserConfiguration.AdminUserId,
                    RoleId = RoleConfiguration.AdminRoleId
                }
            );
        }
    }
}
