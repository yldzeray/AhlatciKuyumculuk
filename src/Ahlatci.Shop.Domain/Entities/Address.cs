using AhlatciKuyumculuk.Shop.Domain.Common;

namespace AhlatciKuyumculuk.Shop.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int CityId { get; set; }
        public string Text { get; set; }

        public City City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
