﻿using AhlatciKuyumculuk.Shop.Application.Models.Dtos.OrderDetails;
using AhlatciKuyumculuk.Shop.Domain.Entities;

namespace AhlatciKuyumculuk.Shop.Application.Models.Dtos.Orders
{
    public class OrderDto
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderDetailDto> OrderDetails { get; set; }
    }
}
