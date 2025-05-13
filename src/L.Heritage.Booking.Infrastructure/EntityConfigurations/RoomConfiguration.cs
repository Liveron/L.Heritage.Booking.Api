using L.Heritage.Booking.Domain.AggregateModel.CustomerAggregate;
using L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L.Heritage.Booking.Infrastructure.EntityConfigurations;

class RoomBookingTypeConfiguration : IEntityTypeConfiguration<RoomBooking>
{
    public void Configure(EntityTypeBuilder<RoomBooking> roomBookingConfiguration)
    {
        roomBookingConfiguration.ToTable("room_booking");

        roomBookingConfiguration.HasOne<Customer>()
            .WithMany()
            .HasForeignKey(rb => rb.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        roomBookingConfiguration.HasOne<Room>()
            .WithMany()
            .HasForeignKey(rb => rb.RoomId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
