namespace w4TR1x.Waydentity.Configurations;

public partial class TenantConfiguration<TUserId, TTenantId, TRoleId, TClaimId>
   : IEntityTypeConfiguration<Tenant<TUserId, TTenantId, TRoleId, TClaimId>>
   where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
   where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
   where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
   where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public void Configure(EntityTypeBuilder<Tenant<TUserId, TTenantId, TRoleId, TClaimId>> builder)
    {
        builder.Configure();
    }
}
