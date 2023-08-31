using System;
using System.Collections.Generic;

namespace VinylCollection.Data.Models;

public partial class VinylRecord
{
    public int VinylRecordId { get; set; }

    public string? AlbumName { get; set; }

    public string? ArtistFirstName { get; set; }

    public string? ArtistLastName { get; set; }

    public string? FavoriteSong { get; set; }

    public DateTime? YearReleased { get; set; }

    public int? Rating { get; set; }
}
