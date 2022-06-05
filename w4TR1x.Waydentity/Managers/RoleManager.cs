using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w4TR1x.Waydentity.Interfaces.Managers;

namespace w4TR1x.Waydentity.Managers
{
    public partial class IdentityManager<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> 
        : IIdentityManager<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>
    where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IEquatable<TRoleId>
     where TClaimId : struct, IComparable, IComparable<TClaimId>, IEquatable<TClaimId>
    {
       
        public Task<List<TRole>> GetRolesByUserIdAsync(TUserId userId)
        {
            return _context.UserRoles.Where(ur => ur.UserId.Equals(userId)).Select(ur => ur.Role).ToListAsync();
        }
        public Task<TRole?> GetRoleByIdAsync(TRoleId roleId)
        {
            return _context.Roles.FirstOrDefaultAsync(r => r.Id.Equals(roleId));
        }
    }
}
