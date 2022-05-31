namespace w4TR1x.Waydentity.Interfaces.Entities;

public interface IUpdatableEntity<TUserId> : IBaseEntity where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
{
    DateTime? UpdatedAt { get; }
    TUserId? UpdatedBy { get; set; }

    void SetUpdatedAt(DateTime updatedAt, TUserId updatedBy);
}
