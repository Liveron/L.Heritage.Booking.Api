using L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;
using MediatR;

namespace L.Heritage.Booking.Api.Application.Commands;

public class CreateBookingDraftCommandHandler
    : IRequestHandler<CreateBookingDraftCommand>
{
    public Task Handle(CreateBookingDraftCommand request, CancellationToken cancellationToken)
    {
        var booking = RoomBooking.NewDraft();
        var rooms = request.Rooms;
        foreach (var room in rooms)
        {
            booking.AddRoom(room.RoomId, room.PricePerNight, room.Discount);
        }

        return Task.CompletedTask;
    }
}
