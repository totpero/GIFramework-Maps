using GIFrameworkMaps.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace GIFrameworkMaps.Data;

public static class ApplicationDbContextModelCreatingExtensions
{
    public static void ApplyConfiguration(this ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ShortLinkConfiguration());
        builder.ApplyConfiguration(new BookmarkConfiguration());
    }
}