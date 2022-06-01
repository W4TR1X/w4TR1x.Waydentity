namespace w4TR1x.Waydentity.Configurations
{
    public partial class UserConfiguration<TUserId, TTenantId, TRoleId, TClaimId> where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public class ClaimConfiguration<TUserId, TTenantId, TRoleId, TClaimId>
       : IEntityTypeConfiguration<Claim<TUserId, TTenantId, TRoleId, TClaimId>>
       where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
       where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
       where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
       where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
        {
            public void Configure(EntityTypeBuilder<Claim<TUserId, TTenantId, TRoleId, TClaimId>> builder)
            {
                builder.Configure();
                              
            }
        }
    }
}
