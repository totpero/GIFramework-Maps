using GIFrameworkMaps.Data.Constants;
using GIFrameworkMaps.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GIFrameworkMaps.Data.EntitiesConfiguration;

public class ShortLinkConfiguration : IEntityTypeConfiguration<ShortLink>
{
    public void Configure(EntityTypeBuilder<ShortLink> builder)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));

        builder.ToTable(GIFrameworkMapConsts.DbTablePrefix + nameof(ShortLink), GIFrameworkMapConsts.DboSchema);
        //builder.PrimaryKey("PK_ShortLink", x => x.ShortId);

        builder.HasKey(s => s.ShortId); //PK_ShortLink

        builder.Property(q => q.ShortId)
            .HasColumnName(nameof(ShortLink.ShortId)); 
        
        builder.Property(q => q.FullUrl)
            .IsRequired(false)
            .HasColumnName(nameof(ShortLink.FullUrl));
         
        builder.Property(q => q.LastVisited)
            .IsRequired(false)
            .HasColumnName(nameof(ShortLink.LastVisited));

        builder.Property(s => s.Created)
            .IsRequired()
            .HasColumnName(nameof(ShortLink.Created))
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            ;
    }
}