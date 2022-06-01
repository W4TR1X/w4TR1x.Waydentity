namespace w4TR1x.Waydentity.Configurations
{
    public partial class UserRoleConfiguration<TUserId, TTenantId, TRoleId, TClaimId>
       : IEntityTypeConfiguration<UserRole<TUserId, TTenantId, TRoleId, TClaimId>>
       where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
       where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
       where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
       where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public void Configure(EntityTypeBuilder<UserRole<TUserId, TTenantId, TRoleId, TClaimId>> builder)
        {
            builder.Configure();

            builder.HasKey(ur => new { ur.UserId, ur.RoleId });
            
            builder.HasOne(ur => ur.User)
               .WithMany(u => u.UserRoles)
               .HasForeignKey(ur => ur.UserId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
