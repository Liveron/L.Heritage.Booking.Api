using L.Heritage.Booking.Domain.Base;

namespace L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;

public class RoomBooking : Entity
{
    public DateTime CheckInDate { get; private set; }

    public DateTime CheckOutDate { get; private set; }

    public RoomBookingStatus Status { get; private set; }

    public decimal TotalPrice { get; private set; }

    public long RoomId { get; private set; }

    public long CustomerId { get; private set; }

    public DateTime CreatedAt { get; set; }

    public RoomBooking(long roomId, long customerId, DateTime checkInDate, DateTime checkOutDate)
    {
        RoomId = roomId;
        CustomerId = customerId;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        Status = RoomBookingStatus.Submitted;
        CreatedAt = DateTime.Now;
    }
}
