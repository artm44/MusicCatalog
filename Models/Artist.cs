using System.Collections.Generic;
using MusicCatalog.Models.Interfaces;

namespace MusicCatalog.Models
{
    public class Artist : IMyName
    {
        public string Name { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Song> Songs { get; set; }
        public override string ToString() { return "Artist: \"" + Name + "\""; }
    }
}
