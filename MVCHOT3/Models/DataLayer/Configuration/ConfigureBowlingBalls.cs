using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace MVCHOT3.Models
{
    internal class ConfigureBowlingBalls : IEntityTypeConfiguration<BowlingBall>
    {
        public void Configure( EntityTypeBuilder<BowlingBall> entity )
        {
            entity.HasData(
            new { Id = 1, Name = "Venom Shock", Brand = "Motiv", Price = 174.99M, ImageFileName = "motiv-venom-shock.jpg"},
            new { Id = 2, Name = "No Rules Exist", Brand = "Roto Grip", Price = 249.95M, ImageFileName = "roto-grip-no-rules-exist.jpg"},
            new { Id = 3, Name = "Extreme Envy", Brand = "Hammer", Price = 194.95M, ImageFileName = "hammer-extreme-envy.jpg"},
            new { Id = 4, Name = "Antidote", Brand = "Pyramid", Price = 109.99M, ImageFileName = "pyramid-antidote.jpg"},
            new { Id = 5, Name = "Blood Moon Rising", Brand = "Pyramid", Price = 124.99M, ImageFileName = "pyramid-blood-moon-rising.jpg"}
            );
        }
    }
}
