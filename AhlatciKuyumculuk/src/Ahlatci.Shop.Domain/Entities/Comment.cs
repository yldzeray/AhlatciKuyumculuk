using AhlatciKuyumculuk.Shop.Domain.Common;

namespace AhlatciKuyumculuk.Shop.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Detail { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public bool? IsApproved { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
