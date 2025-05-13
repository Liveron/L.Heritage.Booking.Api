using L.Heritage.Booking.Api.Application.Commands;
using Microsoft.AspNetCore.Mvc;

namespace L.Heritage.Booking.Api.Controllers;

[ApiController]
[Route("api/booking")]
public class BookingController(BookingServices services) : ControllerBase
{
    public async Task CreateBookingDraft(CreateBookingDraftCommand command)
    {
        await services.Mediator.Send(command);
    }
}
