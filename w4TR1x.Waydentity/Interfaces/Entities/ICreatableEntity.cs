namespace w4TR1x.Waydentity.Interfaces.Entities;

public interface ICreatableEntity<TUserId> : IBaseEntity where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
{
    DateTime CreatedAt { get; }
    TUserId CreatedBy { get; set; }

    void SetCreatedAt(DateTime createdAt, TUserId createdBy);
}
