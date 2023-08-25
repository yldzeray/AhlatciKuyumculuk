using AhlatciKuyumculuk.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AhlatciKuyumculuk.Shop.Persistence.Mappings
{
    public class CityMapping : BaseEntityMapping<City>
    {
        public override void ConfigureDerivedEntityMapping(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .HasColumnType("nvarchar(20)")
                .HasColumnOrder(2)
                .IsRequired();

            builder.ToTable("CITIES");
        }
    }
}
