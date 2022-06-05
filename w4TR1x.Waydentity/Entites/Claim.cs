namespace w4TR1x.Waydentity.Entites
{
    public class Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> : BaseIDCUDEntity<TUserId>
      where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
        where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IEquatable<TClaimId>
    {
        public string ClaimType { get; set; } = null!;
        public string ClaimValue { get; set; } = null!;

        public virtual ICollection<RoleClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> RoleClaims { get; set; } = null!;
        public virtual ICollection<UserClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> UserClaims { get; set; } = null!;
    }
}
