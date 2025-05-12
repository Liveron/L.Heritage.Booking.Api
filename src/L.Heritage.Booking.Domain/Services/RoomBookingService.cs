using L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;
using L.Heritage.Booking.Domain.Exceptions;

namespace L.Heritage.Booking.Domain.Services;

public class RoomBookingService(IRoomRepository roomRepository)
{
    private readonly IRoomRepository _roomRepository = 
        roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));

    public async Task<bool> CheckRoomAvailableForBooking(long roomId, DateTime checkIn, DateTime checkOut)
    {
        if (checkIn >= checkOut || checkOut < DateTime.UtcNow)
            throw new IncorrectBookingDateException(checkIn, checkOut);

        var room = await _roomRepository.GetById(roomId);
        
        bool hasOverlappingBookings = room.Bookings.Any(booking =>
            (booking.CheckOutDate > checkIn) && (booking.CheckInDate < checkOut));

        return !hasOverlappingBookings;
    }
}
