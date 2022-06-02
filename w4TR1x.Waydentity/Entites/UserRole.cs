namespace w4TR1x.Waydentity.Entites
{
    public class UserRole<TUserId, TTenantId, TRoleId, TClaimId> : BaseCUDEntity<TUserId>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public TUserId UserId { get; set; }
        public TRoleId RoleId { get; set; }

        public virtual User<TUserId, TTenantId, TRoleId, TClaimId> User { get; set; } = null!;
        public virtual Role<TUserId, TTenantId, TRoleId, TClaimId> Role { get; set; } = null!;
    }
}
