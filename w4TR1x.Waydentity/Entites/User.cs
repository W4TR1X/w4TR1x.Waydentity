using w4TR1x.Waydentity.Entites.Abstract;

namespace w4TR1x.Waydentity.Entites;

public class User<TUserId,TTenantId,TRoleId,TClaimId>: BaseIDCUDEntity<TUserId> 
    where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
    public Guid ConcurrencyStamp { get; set; }
    public TTenantId? TenantId { get; set; }
   

    public virtual Tenant<TUserId,TTenantId,TRoleId,TClaimId> Tenant { get; set; }
    public virtual ICollection<UserClaim<TUserId, TTenantId, TRoleId, TClaimId>> UserClaims { get; set; }
    public virtual ICollection<UserRole<TUserId, TTenantId, TRoleId, TClaimId>> UserRoles { get; set; }
}