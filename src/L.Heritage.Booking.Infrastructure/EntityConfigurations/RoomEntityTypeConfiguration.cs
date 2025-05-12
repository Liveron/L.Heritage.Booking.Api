using L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L.Heritage.Booking.Infrastructure.EntityConfigurations;

class RoomEntityTypeConfiguration : IEntityTypeConfiguration<BookingItem>
{
    public void Configure(EntityTypeBuilder<BookingItem> roomConfiguration)
    {
        roomConfiguration.ToTable("room");

        roomConfiguration.Property(r => r.PricePerNight)
            .HasPrecision(18, 2);
    }
}
