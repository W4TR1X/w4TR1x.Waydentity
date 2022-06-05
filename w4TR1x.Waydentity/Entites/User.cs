namespace w4TR1x.Waydentity.Entites;

public abstract class User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> : BaseIDCUDEntity<TUserId>
      where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()  
    where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>,  IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>,  IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>, IEquatable<TClaimId>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public bool EmailConfirmed { get; set; }
    public string PasswordHash { get; set; } = null!;
    public string PasswordSalt { get; set; } = null!;
    public Guid ConcurrencyStamp { get; set; }
    public TTenantId? TenantId { get; set; }

    public virtual TTenant? Tenant { get; set; }
    public virtual ICollection<UserClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> UserClaims { get; set; } = null!;
    public virtual ICollection<UserRole<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> UserRoles { get; set; } = null!;
}