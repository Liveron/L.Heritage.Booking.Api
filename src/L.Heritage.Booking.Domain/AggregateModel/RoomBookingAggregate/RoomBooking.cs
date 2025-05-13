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

    private bool _isDraft;

    private readonly List<Room> _rooms;

    public IReadOnlyCollection<Room> Rooms => _rooms.AsReadOnly();

    protected RoomBooking()
    {
        _rooms = [];
        _isDraft = false;
    }

    public RoomBooking(long roomId, long customerId, DateTime checkInDate, DateTime checkOutDate) : this()
    {
        RoomId = roomId;
        CustomerId = customerId;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        Status = RoomBookingStatus.Submitted;
        CreatedAt = DateTime.Now;
    }

    public void AddRoom(int roomId, decimal pricePerNight, decimal discount)
    {
        var existingBookingForRoom = _rooms.SingleOrDefault(b => b.RoomId == roomId);

        if (existingBookingForRoom is not null)
        {
            if (discount > existingBookingForRoom.Discount)
            {
                existingBookingForRoom.SetNewDiscount(discount);
            }
        }
        else
        {
            var room = new Room(roomId, discount, pricePerNight);
            _rooms.Add(room);
        }
    }

    public static RoomBooking NewDraft()
    {
        return new RoomBooking { _isDraft = true };
    }
}
