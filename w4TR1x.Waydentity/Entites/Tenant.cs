using w4TR1x.Waydentity.Entites.Abstract;

namespace w4TR1x.Waydentity.Entites;

public class Tenant<TUserId,TTenantId,TRoleId,TClaimId>:BaseIDCUDEntity<TUserId>
    where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public string Name { get; set; }

    public virtual ICollection<User<TUserId,TTenantId,TRoleId,TClaimId>> Users { get; set; }
    public virtual ICollection<Role<TUserId, TTenantId, TRoleId, TClaimId>> Roles { get; set; }
}