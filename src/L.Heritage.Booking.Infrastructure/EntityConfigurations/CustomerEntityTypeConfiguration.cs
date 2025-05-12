using L.Heritage.Booking.Domain.AggregateModel.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L.Heritage.Booking.Infrastructure.EntityConfigurations;

class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> customerConfiguration)
    {
        customerConfiguration.ToTable("customers");
    }
}
