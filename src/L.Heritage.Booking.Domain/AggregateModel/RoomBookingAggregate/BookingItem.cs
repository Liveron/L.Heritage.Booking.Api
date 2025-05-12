using L.Heritage.Booking.Domain.Base;

namespace L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;

public class BookingItem : Entity
{
    public int RoomId { get; set; }

    public decimal PricePerNight { get; private set; }
}
