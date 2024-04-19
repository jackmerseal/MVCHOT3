using System.ComponentModel.DataAnnotations;
namespace MVCHOT3.Models
{
	public class BowlingBall
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Name is Required")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "Brand is Required")]
		public string? Brand { get; set; }
		[Required(ErrorMessage = "Price is Required")]
		[Range(0, 1000, ErrorMessage = "Price must be between 0 and 1000")]
		public decimal Price { get; set; }
		public string? ImageFileName { get; set; }
		public string Slug => $"{Brand}-{Name}".ToLower().Replace(" ", "-");
	}
}
