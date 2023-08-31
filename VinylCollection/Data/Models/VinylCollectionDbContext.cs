using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VinylCollection.Data.Models;

public partial class VinylCollectionDbContext : DbContext
{
    public VinylCollectionDbContext()
    {
    }

    public VinylCollectionDbContext(DbContextOptions<VinylCollectionDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VinylRecord> VinylRecords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VinylRecord>(entity =>
        {
            entity.Property(e => e.AlbumName).HasMaxLength(200);
            entity.Property(e => e.ArtistFirstName).HasMaxLength(100);
            entity.Property(e => e.ArtistLastName).HasMaxLength(100);
            entity.Property(e => e.FavoriteSong).HasMaxLength(50);
            entity.Property(e => e.YearReleased).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
