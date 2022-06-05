namespace w4TR1x.Waydentity.Entites;

public class RoleClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> : BaseCUDEntity<TUserId>
      where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new() 
    
    where TUserId : struct, IComparable, IComparable<TUserId>,  IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>,  IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>,  IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>,  IEquatable<TClaimId>
{
    public TRoleId RoleId { get; set; }
    public TClaimId ClaimId { get; set; }

    public virtual TRole Role { get; set; } = null!;
    public virtual TClaim Claim { get; set; } = null!;
}
