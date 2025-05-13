using L.Heritage.Booking.Api.Infrastructure.Services;
using MediatR;

namespace L.Heritage.Booking.Api.Controllers;

public class BookingServices(
    IMediator mediator,
    ILogger<BookingServices> logger,
    IIdentityService identityService)
{
    public IMediator Mediator { get; init; } = mediator;
    public ILogger<BookingServices> Logger { get; init; } = logger;
    public IIdentityService IdentityService { get; init; } = identityService;
}
