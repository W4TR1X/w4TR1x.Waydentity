namespace w4TR1x.Waydentity.Entites;

public class Role<TUserId, TTenantId, TRoleId, TClaimId> : BaseIDCUDEntity<TUserId>
    where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public string Name { get; set; } = null!;
    public string ConcurrencyStamp { get; set; } = null!;
    public TTenantId? TenantId { get; set; }

    public virtual Tenant<TUserId, TTenantId, TRoleId, TClaimId>? Tenant { get; set; }
    public virtual ICollection<RoleClaim<TUserId, TTenantId, TRoleId, TClaimId>> RoleClaims { get; set; } = null!;
    public virtual ICollection<UserRole<TUserId, TTenantId, TRoleId, TClaimId>> UserRoles { get; set; } = null!;
}