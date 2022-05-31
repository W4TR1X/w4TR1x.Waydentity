namespace w4TR1x.Waydentity.Interfaces.Entities;

public interface IDeletableEntity<TUserId> : IBaseEntity where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
{
    DateTime? DeletedAt { get; }
    TUserId? DeletedBy { get; set; }

    void SetDeletedAt(DateTime deletedAt, TUserId deletedBy);
}