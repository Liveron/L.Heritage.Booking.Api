namespace L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;

public enum RoomBookingStatus : byte
{
    Submitted = 1,
    AwaitingValidation = 2,
    Validated = 3,
    Paid = 4,
    Cancelled = 5,
}
