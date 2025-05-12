namespace L.Heritage.Booking.Domain.Base;

public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}
