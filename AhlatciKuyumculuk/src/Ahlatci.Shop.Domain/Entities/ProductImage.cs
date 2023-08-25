using AhlatciKuyumculuk.Shop.Domain.Common;

namespace AhlatciKuyumculuk.Shop.Domain.Entities
{
    public class ProductImage : AuditableEntity
    {
        public int ProductId { get; set; }
        public string Path { get; set; }
        public int Order { get; set; }
        public bool? IsThumbnail { get; set; }

        public Product Product { get; set; }
    }
}
