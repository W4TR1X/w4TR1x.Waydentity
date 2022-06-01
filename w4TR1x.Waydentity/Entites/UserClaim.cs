using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w4TR1x.Waydentity.Entites.Abstract;

namespace w4TR1x.Waydentity.Entites
{
    public class UserClaim<TUserId,TTenantId,TRoleId,TClaimId> : BaseCUDEntity<TUserId>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public TUserId UserId { get; set; }
        public TClaimId ClaimId { get; set; }

        public virtual User<TUserId,TTenantId,TRoleId,TClaimId> User { get; set; }
        public virtual Claim<TUserId,TTenantId,TRoleId,TClaimId> Claim { get; set; }
    }
}
