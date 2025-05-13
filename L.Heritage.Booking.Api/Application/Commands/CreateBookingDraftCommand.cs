using L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;
using MediatR;

namespace L.Heritage.Booking.Api.Application.Commands;

public record CreateBookingDraftCommand(string CustomerId, IEnumerable<Room> Rooms) : IRequest;
