namespace w4TR1x.Waydentity;




public abstract class WaydentityContext<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId> : DbContext
      where TUser : User<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TTenant : Tenant<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TRole : Role<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TClaim : Claim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>, new()
    where TUserId : struct, IComparable, IComparable<TUserId>, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IEquatable<TRoleId>
     where TClaimId : struct, IComparable, IComparable<TClaimId>, IEquatable<TClaimId>
{
    public TTenantId CurrentTenantId { get; set; }

    public DbSet<TUser> Users { get; set; } = null!;
    public DbSet<TTenant> Tenants { get; set; } = null!;
    public DbSet<TRole> Roles { get; set; } = null!;
    public DbSet<TClaim> Claims { get; set; } = null!;
    public DbSet<RoleClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> RoleClaims { get; set; } = null!;
    public DbSet<UserClaim<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> UserClaims { get; set; } = null!;
    public DbSet<UserRole<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>> UserRoles { get; set; } = null!;

    protected WaydentityContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(WaydentityContext<TUser, TTenant, TRole, TClaim, TUserId, TTenantId, TRoleId, TClaimId>).Assembly);
    }
}