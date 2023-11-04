using GIFrameworkMaps.Data.Constants;
using GIFrameworkMaps.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace GIFrameworkMaps.Data.EntitiesConfiguration;

public class BookmarkConfiguration : IEntityTypeConfiguration<Bookmark>
{
    public void Configure(EntityTypeBuilder<Bookmark> builder)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));

        builder.ToTable(GIFrameworkMapConsts.DbTablePrefix + "Bookmarks", GIFrameworkMapConsts.DboSchema);

        builder.HasKey(s => s.Id);

        builder.Property(q => q.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName(nameof(Bookmark.Id));

        builder.Property(q => q.Name)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName(nameof(Bookmark.Name));

        builder.Property(q => q.X)
            .IsRequired()
            .HasColumnName(nameof(Bookmark.X));

        builder.Property(q => q.Y)
            .IsRequired()
            .HasColumnName(nameof(Bookmark.Y));
        
        builder.Property(q => q.Zoom)
            .IsRequired()
            .HasColumnName(nameof(Bookmark.Zoom));
        
        builder.Property(q => q.UserId)
            .IsRequired()
            .HasColumnName(nameof(Bookmark.UserId));

    }

}