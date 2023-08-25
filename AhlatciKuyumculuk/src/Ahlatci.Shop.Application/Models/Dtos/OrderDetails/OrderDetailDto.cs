﻿using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Products;

namespace AhlatciKuyumculuk.Shop.Application.Models.Dtos.OrderDetails
{
    public class OrderDetailDto
    {
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public CategoryDto Category { get; set; }
        public ProductDto Product { get; set; }
    }
}
