using ASP.NETCoreCustomArch.Entities.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreCustomArch.Entities.Identity.Config;

public class AppRoleClaimConfig : IEntityTypeConfiguration<AppRoleClaim>
{

    public void Configure(EntityTypeBuilder<AppRoleClaim> builder)
    {
        builder.ToTable("roleClaims");
    }
}