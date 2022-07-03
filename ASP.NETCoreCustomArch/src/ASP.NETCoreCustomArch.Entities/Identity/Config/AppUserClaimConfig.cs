using ASP.NETCoreCustomArch.Entities.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreCustomArch.Entities.Identity.Config;

public class AppUserClaimConfig : IEntityTypeConfiguration<AppUserClaim>
{

    public void Configure(EntityTypeBuilder<AppUserClaim> builder)
    {
        builder.ToTable("userClaims");
    }
}