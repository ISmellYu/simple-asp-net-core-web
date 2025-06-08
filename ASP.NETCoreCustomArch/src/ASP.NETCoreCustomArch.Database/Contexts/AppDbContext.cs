using System.Reflection;
using Ardalis.EFCore.Extensions;
using ASP.NETCoreCustomArch.Entities.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreCustomArch.Database.Contexts;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin,
	AppRoleClaim, AppUserToken>
{
	//public AppDbContext(DbContextOptions options) : base(options)
	//{
	//}

	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AppUser)) ??
		                                             throw new InvalidOperationException());

		// alternately this is built-in to EF Core 2.2
		//modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}

	public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
	{
		int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
		return result;
	}

	public override int SaveChanges()
	{
		return SaveChangesAsync().GetAwaiter().GetResult();
	}
}