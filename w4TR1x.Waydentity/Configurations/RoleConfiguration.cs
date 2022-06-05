namespace w4TR1x.Waydentity.Configurations;

public class RoleConfiguration<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>
   : IEntityTypeConfiguration<TRole>
     where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
   where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
   where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
   where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
   where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public void Configure(EntityTypeBuilder<TRole> builder)
    {
        builder.Configure();

        builder.HasOne(r => r.Tenant)
            .WithMany(t => t.Roles)
            .HasForeignKey(u => u.TenantId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
