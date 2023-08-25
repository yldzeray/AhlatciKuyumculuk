using AhlatciKuyumculuk.Shop.Domain.Entities;

namespace AhlatciKuyumculuk.Shop.Application.Models.RequestModels.Orders
{
    public class UpdateOrderVM
    {
        public int? OrderId { get; set; }
        public OrderStatus? StatusId { get; set; }
        public int AddressId { get; set; }
    }
}
