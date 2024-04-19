namespace MVCHOT3.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int BowlingBallId { get; set; }
        public BowlingBall BowlingBall { get; set; }
        public int? Quantity { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? Total { get; set; }
    }
}
