using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w4TR1x.Waydentity.Entites;

namespace w4TR1x.Waydentity.Interfaces.Managers
{
    public interface IIdentityManager<TUser,TTenant,TRole,TClaim,TUserId, TTenantId, TRoleId, TClaimId>
    where TUser : User<TUser, TTenant, TRole, TClaim,TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IEquatable<TRoleId>
     where TClaimId : struct, IComparable, IComparable<TClaimId>, IEquatable<TClaimId>
    {
        Task<TUser?> GetUserByEmailAsync(string email);
        Task<TUser?> GetUserByIdAsync(TUserId userId);
     
        Task<TRole?> GetRoleByIdAsync(TRoleId roleId);
        Task<List<TRole>> GetRolesByUserIdAsync(TUserId userId);

        Task<List<TClaim>> GetUserAndRolesClaimsByUserIdAsync(TUserId userId);
    }
}
