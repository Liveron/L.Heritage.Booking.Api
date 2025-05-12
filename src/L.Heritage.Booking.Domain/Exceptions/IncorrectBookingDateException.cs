namespace L.Heritage.Booking.Domain.Exceptions;

public class IncorrectBookingDateException(DateTime checkInDate, DateTime checkOutDate) : 
    Exception($"Incorrect booking date: check in date {checkInDate}, check out date {checkOutDate}")
{ }
