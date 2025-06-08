using ASP.NETCoreCustomArch.Database.Contexts;
using ASP.NETCoreCustomArch.Entities.Identity.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NETCoreCustomArch.Identity;

public static class Startup
{
	public static void AddAuthStuff(this IServiceCollection services)
	{
		services.AddCustomIdentity();
	}

	private static void AddCustomIdentity(this IServiceCollection services)
	{
		services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
	}
}