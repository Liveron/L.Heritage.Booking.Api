namespace L.Heritage.Booking.Domain.Exceptions;

public class BookingDomainException : Exception
{
    public BookingDomainException() { }

    public BookingDomainException(string message) : base(message) { }
}
