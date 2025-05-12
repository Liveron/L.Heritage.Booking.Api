using L.Heritage.Booking.Domain.AggregateModel.CustomerAggregate;
using L.Heritage.Booking.Domain.AggregateModel.RoomBookingAggregate;
using L.Heritage.Booking.Domain.Base;
using Microsoft.EntityFrameworkCore;

namespace L.Heritage.Booking.Infrastructure;

public class BookingContext : DbContext, IUnitOfWork
{
    public DbSet<RoomBooking> Bookings { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<BookingItem> Rooms { get; set; }
}
