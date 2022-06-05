namespace w4TR1x.Waydentity.Configurations;

public partial class RoleClaimConfiguration<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>
    : IEntityTypeConfiguration<RoleClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>>
      where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
    where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public void Configure(EntityTypeBuilder<RoleClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> builder)
    {
        builder.Configure();

        builder.HasKey(rc => new { rc.RoleId, rc.ClaimId });

        builder.HasOne(rc => rc.Role)
            .WithMany(r => r.RoleClaims)
            .HasForeignKey(rc => rc.RoleId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(rc => rc.Claim)
            .WithMany(c => c.RoleClaims)
            .HasForeignKey(rc => rc.ClaimId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
