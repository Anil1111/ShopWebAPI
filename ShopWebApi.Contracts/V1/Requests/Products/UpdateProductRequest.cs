﻿

namespace ShopWebAPI.Contracts.V1.Requests
{
    public class UpdateProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Url { get; set; }
        public double Price { get; set; }
    }
}
