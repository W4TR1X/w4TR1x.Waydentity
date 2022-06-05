namespace w4TR1x.Waydentity.Configurations;

public class ClaimConfiguration<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>
   : IEntityTypeConfiguration<TClaim>
     where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
   where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
   where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
   where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
   where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public void Configure(EntityTypeBuilder<TClaim> builder)
    {
        builder.Configure();
    }
}