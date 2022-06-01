using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4TR1x.Waydentity.Configurations
{
    public partial class UserConfiguration<TUserId, TTenantId, TRoleId, TClaimId>
        : IEntityTypeConfiguration<User<TUserId, TTenantId, TRoleId, TClaimId>>
        where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
        where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
        where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
        where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
    {
        public void Configure(EntityTypeBuilder<User<TUserId, TTenantId, TRoleId, TClaimId>> builder)
        {
            builder.Configure();

            builder.HasOne(u => u.Tenant)
                .WithMany(t => t.Users)
                .HasForeignKey(u => u.TenantId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
