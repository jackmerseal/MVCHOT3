﻿namespace MVCHOT3.Models.DomainModels
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public BowlingBall BowlingBall { get; set; }
        public int Quantity { get; set; }
    }
}
