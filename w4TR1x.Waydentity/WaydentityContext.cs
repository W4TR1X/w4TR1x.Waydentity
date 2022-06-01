using w4TR1x.Waydentity.Configurations;

namespace w4TR1x.Waydentity;

public abstract class WaydentityContext<TUserId, TTenantId, TRoleId,TClaimId> : DbContext
    where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
     where TClaimId : struct, IComparable, IComparable<TClaimId>, IConvertible, IEquatable<TClaimId>
{
    public TTenantId CurrentTenantId { get; set; }

    public DbSet<User<TUserId, TTenantId, TRoleId, TClaimId>> Users { get; set; } = null!;
    public DbSet<Tenant<TUserId, TTenantId, TRoleId, TClaimId>> Tenants { get; set; } = null!;
    public DbSet<Role<TUserId, TTenantId, TRoleId, TClaimId>> Roles { get; set; } = null!;
    public DbSet<Claim<TUserId, TTenantId, TRoleId, TClaimId>> Claims { get; set; } = null!;
    public DbSet<RoleClaim<TUserId,TTenantId,TRoleId,TClaimId>> RoleClaims { get; set; } = null!;
    public DbSet<UserClaim<TUserId,TTenantId, TRoleId, TClaimId>> UserClaims { get; set; } = null!;
    public DbSet<UserRole<TUserId, TTenantId, TRoleId, TClaimId>> UserRoles { get; set; } = null!;

    protected WaydentityContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(WaydentityContext<TUserId, TTenantId, TRoleId, TClaimId>).Assembly);
    }
}