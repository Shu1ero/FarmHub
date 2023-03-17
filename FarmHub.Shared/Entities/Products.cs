﻿
namespace FarmHub.Shared.Entities
{
    public class Products : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int SellerId { get; set; }
        public int Quantity { get; set; }
    }
}
