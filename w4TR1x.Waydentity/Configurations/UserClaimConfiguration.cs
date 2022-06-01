namespace w4TR1x.Waydentity.Configurations
{
    public partial class UserClaimConfiguration<TUserId, TTenantId, TRoleId, TClaimId>
        : IEntityTypeConfiguration<UserClaim<TUserId, TTenantId, TRoleId, TClaimId>>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public void Configure(EntityTypeBuilder<UserClaim<TUserId, TTenantId, TRoleId, TClaimId>> builder)
        {
            builder.Configure();

            builder.HasKey(uc => new { uc.UserId, uc.ClaimId });

            builder.HasOne(uc => uc.User)
                .WithMany(u => u.UserClaims)
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(uc => uc.Claim)
                .WithMany(c => c.UserClaims)
                .HasForeignKey(uc => uc.ClaimId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
