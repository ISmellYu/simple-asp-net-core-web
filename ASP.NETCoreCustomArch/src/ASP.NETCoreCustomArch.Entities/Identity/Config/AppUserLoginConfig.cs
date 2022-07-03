using ASP.NETCoreCustomArch.Entities.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreCustomArch.Entities.Identity.Config;

public class AppUserLoginConfig : IEntityTypeConfiguration<AppUserLogin>
{

    public void Configure(EntityTypeBuilder<AppUserLogin> builder)
    {
        builder.ToTable("userLogins");
    }
}