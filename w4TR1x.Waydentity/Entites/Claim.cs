using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w4TR1x.Waydentity.Entites.Abstract;

namespace w4TR1x.Waydentity.Entites
{
    public class Claim<TUserId, TTenantId,TRoleId, TClaimId> : BaseIDCUDEntity<TUserId>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual ICollection<RoleClaim<TUserId, TTenantId,TRoleId, TClaimId>> RoleClaims { get; set; }
        public virtual ICollection<UserClaim<TUserId, TTenantId, TRoleId, TClaimId>> UserClaims { get; set; }
    }
}
