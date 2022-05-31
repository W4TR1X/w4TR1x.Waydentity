namespace w4TR1x.Waydentity;

public abstract class WaydentityContext<TUserId, TTenantId, TRoleId> : DbContext
    where TUserId : struct, IComparable, IComparable<TUserId>, IConvertible, IEquatable<TUserId>
    where TTenantId : struct, IComparable, IComparable<TTenantId>, IConvertible, IEquatable<TTenantId>
    where TRoleId : struct, IComparable, IComparable<TRoleId>, IConvertible, IEquatable<TRoleId>
{
    public TTenantId CurrentTenantId { get; set; }

    public DbSet<User<TUserId>> Users { get; set; } = null!;
    public DbSet<Tenant<TTenantId>> Tenants { get; set; } = null!;
    public DbSet<Role<TRoleId>> Roles { get; set; } = null!;

    protected WaydentityContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User<TUserId>>(c => c.Configure());
        modelBuilder.Entity<Tenant<TTenantId>>(c => c.Configure());
        modelBuilder.Entity<Role<TRoleId>>(c => c.Configure());
    }
}