namespace w4TR1x.Waydentity.Extensions;

public static class GuidConfigurationExtensions
{
    public static void ConfigureGuid(this PropertyBuilder<Guid> builder)
    {
        builder.HasColumnType("uniqueidentifier")
            .IsRequired();
    }
    public static void ConfigureGuid(this PropertyBuilder<Guid?> builder)
    {
        builder.HasColumnType("uniqueidentifier");
    }
}
