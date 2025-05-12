namespace L.Heritage.Booking.Domain.Base;

public abstract class Entity
{
    int? _requestedHashCode;
    long _id;

    public virtual long Id
    {
        get => _id;
        protected set => _id = value;
    }

    public bool IsTransient() => Id == default;

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Entity)
            return false;

        if (object.ReferenceEquals(this, obj))
            return true;

        if (this.GetType() != obj.GetType())
            return false;

        Entity item = (Entity)obj;

        if (item.IsTransient() || this.IsTransient())
            return false;
        else
            return item.Id == this.Id;
    }

    public override int GetHashCode()
    {
        if (!IsTransient())
        {
            if (!_requestedHashCode.HasValue)
                _requestedHashCode = this.Id.GetHashCode() ^ 31;

            return _requestedHashCode.Value;
        }
        else
            return base.GetHashCode();
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (object.Equals(left, null))
            return object.Equals(right, null);
        else
            return left.Equals(right);
    }

    public static bool operator !=(Entity left, Entity right) => !(left == right);
}
