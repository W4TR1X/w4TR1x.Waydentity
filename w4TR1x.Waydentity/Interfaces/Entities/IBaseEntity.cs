namespace w4TR1x.Waydentity.Interfaces.Entities;

public interface IBaseEntity
{
}

public interface IBaseEntity<TUserId> : IBaseEntity where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
{
    TUserId Id { get; set; }
}