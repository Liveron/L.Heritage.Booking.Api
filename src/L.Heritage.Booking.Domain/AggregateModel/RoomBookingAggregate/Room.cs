using L.Heritage.Booking.Domain.Base;
using L.Heritage.Booking.Domain.Exceptions;

namespace L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;

public class Room : Entity
{
    public int RoomId { get; set; }

    public decimal Discount { get; private set; }

    public decimal PricePerNight { get; private set; }

    public Room(int roomId, decimal discount, decimal pricePerNight)
    {
        RoomId = roomId;
        Discount = discount;
        PricePerNight = pricePerNight;
    }

    public void SetNewDiscount(decimal discount)
    {
        if (discount < 0)
        {
            throw new BookingDomainException("Discount is not valid.");
        }

        Discount = discount;
    }
}
