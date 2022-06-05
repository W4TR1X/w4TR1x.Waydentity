namespace w4TR1x.Waydentity.Entites.Abstract;

public abstract class BaseEntity : IBaseEntity
{
}

public abstract class BaseIDEntity<TUserId> : IBaseEntity<TUserId>
    where TUserId : struct, IComparable, IComparable<TUserId>,  IEquatable<TUserId>
{
    public TUserId Id { get; set; }
}

public abstract class BaseIDCUDEntity<TUserId> :
    BaseIDEntity<TUserId>,
    ICreatableEntity<TUserId>,
    IUpdatableEntity<TUserId>,
    IDeletableEntity<TUserId>
    where TUserId : struct, IComparable, IComparable<TUserId>,  IEquatable<TUserId>
{
    public DateTime CreatedAt { get; set; }
    public TUserId CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
    public TUserId? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }
    public TUserId? DeletedBy { get; set; }

    public void SetCreatedAt(DateTime createdAt, TUserId createdBy)
    {
        CreatedAt = createdAt;
        CreatedBy = createdBy;
    }

    public void SetDeletedAt(DateTime deletedAt, TUserId deletedBy)
    {
        DeletedAt = deletedAt;
        DeletedBy = deletedBy;
    }

    public void SetUpdatedAt(DateTime updatedAt, TUserId updatedBy)
    {
        UpdatedAt = updatedAt;
        UpdatedBy = updatedBy;
    }
}
public abstract class BaseCUDEntity<TUserId> :
    BaseEntity,
    ICreatableEntity<TUserId>,
    IUpdatableEntity<TUserId>,
    IDeletableEntity<TUserId>
    where TUserId : struct, IComparable, IComparable<TUserId>,  IEquatable<TUserId>
{
    public DateTime CreatedAt { get; set; }
    public TUserId CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
    public TUserId? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }
    public TUserId? DeletedBy { get; set; }

    public void SetCreatedAt(DateTime createdAt, TUserId createdBy)
    {
        CreatedAt = createdAt;
        CreatedBy = createdBy;
    }

    public void SetDeletedAt(DateTime deletedAt, TUserId deletedBy)
    {
        DeletedAt = deletedAt;
        DeletedBy = deletedBy;
    }

    public void SetUpdatedAt(DateTime updatedAt, TUserId updatedBy)
    {
        UpdatedAt = updatedAt;
        UpdatedBy = updatedBy;
    }
}
