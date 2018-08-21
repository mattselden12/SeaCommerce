	using Microsoft.EntityFrameworkCore;
	namespace SeaCommerce.Models
	{
		public class SeaCommerceContext : DbContext
		{
		// base() calls the parent class' constructor passing the "options" parameter along
		public SeaCommerceContext(DbContextOptions<SeaCommerceContext> options) : base(options) { }
		public DbSet<Admin> admins { get; set; }
		public DbSet<Player> players { get; set; }
		public DbSet<Order> orders { get; set; }
		public DbSet<Category> categories { get; set; }
		public DbSet<PlayerCategories> playercategories { get; set; }
		public DbSet<PlayersOrdered> playersordered { get; set; }
		}
	}
