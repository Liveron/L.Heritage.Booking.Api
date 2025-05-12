namespace L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;

public interface IRoomRepository
{
    public Task<BookingItem> GetById(long roomId);
}
