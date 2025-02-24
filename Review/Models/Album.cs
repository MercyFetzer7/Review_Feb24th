using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Review.Models;

public class Album
{
    [Key]
    public int AlbumId { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    [Required]
    public int ArtistId { get; set; }
    [ForeignKey("ArtistId")]
    public Artist Artist { get; set; }
    
    
}