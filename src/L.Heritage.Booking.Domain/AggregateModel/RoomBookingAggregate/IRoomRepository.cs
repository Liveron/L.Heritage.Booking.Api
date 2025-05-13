namespace L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;

public interface IRoomRepository
{
    public Task<Room> GetById(long roomId);
}
