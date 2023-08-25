using AhlatciKuyumculuk.Shop.Domain.Common;

namespace AhlatciKuyumculuk.Shop.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }

        //Navigation Property
        public ICollection<Product> Products { get; set; }

    }
}


