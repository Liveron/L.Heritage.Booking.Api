using System.ComponentModel.DataAnnotations;
using L.Heritage.Booking.Domain.Base;

namespace L.Heritage.Booking.Domain.AggregateModel.CustomerAggregate;

public class Customer : IAggregateRoot
{
    public Guid IdentityId { get; private set; }

    [Required]
    public string Name { get; set; } = null!;

    public Customer(string name)
    {
        Name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentNullException(nameof(name));
    }
}
