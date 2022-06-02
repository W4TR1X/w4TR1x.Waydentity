namespace w4TR1x.Waydentity.Entites
{
    public class Claim<TUserId, TTenantId, TRoleId, TClaimId> : BaseIDCUDEntity<TUserId>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public string ClaimType { get; set; } = null!;
        public string ClaimValue { get; set; } = null!;

        public virtual ICollection<RoleClaim<TUserId, TTenantId, TRoleId, TClaimId>> RoleClaims { get; set; } = null!;
        public virtual ICollection<UserClaim<TUserId, TTenantId, TRoleId, TClaimId>> UserClaims { get; set; } = null!;
    }
}
