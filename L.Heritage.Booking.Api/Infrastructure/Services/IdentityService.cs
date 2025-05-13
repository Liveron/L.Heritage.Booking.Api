namespace L.Heritage.Booking.Api.Infrastructure.Services;

public class IdentityService(IHttpContextAccessor context) : IIdentityService
{
    public string? GetUserIdentity() =>
        context.HttpContext?.User.FindFirstValue("sub");
}
