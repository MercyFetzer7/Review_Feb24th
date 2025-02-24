using System.ComponentModel.DataAnnotations;

namespace Review.Models;

public class Artist
{
    [Key]
    public int ArtistId { get; set; }
    public string? Name { get; set; }
}