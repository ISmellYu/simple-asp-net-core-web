using ASP.NETCoreCustomArch.Database.Contexts;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ASP.NETCoreCustomArch.Database;

public class DefaultDatabaseModule : Module
{
    private readonly IConfiguration _configuration;
    
    public DefaultDatabaseModule(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    protected override void Load(ContainerBuilder builder)
    {
        var connectionString = _configuration.GetConnectionString("SqliteConnection");
        var cxd = new DbContextOptionsBuilder<AppDbContext>().UseSqlite(connectionString).EnableSensitiveDataLogging();
        // var dbContextOptionsBuilder = new DbContextOptionsBuilder<AppDbContext>().
        //     UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).EnableSensitiveDataLogging();

        builder.RegisterType<AppDbContext>()
            .WithParameter("options", cxd.Options);
    }
}