namespace w4TR1x.Waydentity.Entites;

public abstract class Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> : BaseIDCUDEntity<TUserId>
    where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TUserId : struct, IComparable, IComparable<TUserId>,  IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>,  IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>,  IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>,  IEquatable<TClaimId>
{
    public string Name { get; set; } = null!;
    public string ConcurrencyStamp { get; set; } = null!;
    public TTenantId? TenantId { get; set; }

    public virtual TTenant? Tenant { get; set; }
    public virtual ICollection<RoleClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> RoleClaims { get; set; } = null!;
    public virtual ICollection<UserRole<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> UserRoles { get; set; } = null!;
}