using System.Collections.Generic;

namespace MusicCatalog.Models.Interfaces
{
    public interface ICatalog
    {
        IEnumerable<Song> Songs { get; set; }
        IEnumerable<Artist> Artists { get; set; }
        IEnumerable<Album> Albums { get; set; }
        IEnumerable<Collection> Collections { get; set; }
    }
}
