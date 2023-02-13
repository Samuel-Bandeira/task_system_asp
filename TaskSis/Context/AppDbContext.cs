using Microsoft.EntityFrameworkCore;
using TaskSis.Models;

namespace TaskSis.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{ }

		public DbSet<Category> Category { get; set; }
		public DbSet<Product> Product { get; set; }
	}
}
