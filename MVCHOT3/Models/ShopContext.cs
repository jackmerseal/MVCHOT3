using Microsoft.EntityFrameworkCore;
namespace MVCHOT3.Models
{
	public class ShopContext : DbContext
	{
		public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

		public DbSet<BowlingBall> BowlingBalls { get; set; }
		public DbSet<Purchase> Purchases { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<BowlingBall>().HasData(
			new BowlingBall
			{
				Id = 1,
				Name = "Venom Shock",
				Brand = "Motiv",
				Price = 174.99M,
				ImageFileName = "motiv-venom-shock.jpg"
			},
			new BowlingBall
			{
				Id = 2,
				Name = "No Rules Exist",
				Brand = "Roto Grip",
				Price = 249.95M,
				ImageFileName = "roto-grip-no-rules-exist.jpg"
			},
			new BowlingBall
			{
				Id = 3,
				Name = "Extreme Envy",
				Brand = "Hammer",
				Price = 194.95M,
				ImageFileName = "hammer-extreme-envy.jpg"
			},
			new BowlingBall
			{
				Id = 4,
				Name = "Antidote",
				Brand = "Pyramid",
				Price = 109.99M,
				ImageFileName = "pyramid-antidote.jpg"
			},
			new BowlingBall
			{
				Id = 5,
				Name = "Blood Moon Rising",
				Brand = "Pyramid",
				Price = 124.99M,
				ImageFileName = "pyramid-blood-moon-rising.jpg"
			}
			);
		}
	}
}
