using ASP.NETCoreCustomArch.Entities.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreCustomArch.Entities.Identity.Config;

public class AppUserTokenConfig : IEntityTypeConfiguration<AppUserToken>
{

    public void Configure(EntityTypeBuilder<AppUserToken> builder)
    {
        builder.ToTable("userTokens");
    }
}