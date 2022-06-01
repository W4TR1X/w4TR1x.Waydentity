using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w4TR1x.Waydentity.Entites.Abstract;

namespace w4TR1x.Waydentity.Entites
{
    public class RoleClaim<TUserId,TTenantId,TRoleId,TClaimId> : BaseCUDEntity<TUserId>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public TRoleId RoleId { get; set; }
        public TClaimId ClaimId { get; set; }

       

        public virtual Role<TUserId,TTenantId,TRoleId,TClaimId> Role { get; set; }
        public virtual Claim<TUserId, TTenantId,TRoleId, TClaimId> Claim { get; set; }
    }
}
