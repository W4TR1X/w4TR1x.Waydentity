using System;
using System.Collections.Generic;
using System.Globalization;
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

        private readonly WaydentityContext<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> _context;
        public IdentityManager(WaydentityContext<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> context)
        {
            _context = context;
        }

      

        public async Task<List<TClaim>> GetUserAndRolesClaimsByUserIdAsync(TUserId userId)
        {
            return await _context.Users
                   .Where(u => u.Id.Equals(userId))
                   .Include(u => u.UserClaims)
                       .ThenInclude(uc => uc.Claim)
                   .Include(u => u.UserRoles)
                     .ThenInclude(ur => ur.Role)
                         .ThenInclude(r => r.RoleClaims)
                             .ThenInclude(rc => rc.Claim)
                    .SelectMany(u =>
                        u.UserClaims.Select(uc => uc.Claim)
                        .Union(u.UserRoles.SelectMany(ur => ur.Role.RoleClaims).Select(rc => rc.Claim))
                    )
                   .ToListAsync();
        }

        public Task<TUser?> GetUserByEmailAsync(string email)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower(CultureInfo.GetCultureInfo("en-Us")) == email.ToLower(CultureInfo.GetCultureInfo("en-Us")));
        }

        public Task<TUser?> GetUserByIdAsync(TUserId userId)
        {
            return _context.Users.FirstOrDefaultAsync(u=>u.Id.Equals(userId));
        }
    }
}
