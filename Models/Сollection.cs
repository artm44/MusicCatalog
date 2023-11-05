using System.Collections.Generic;
using MusicCatalog.Models.Interfaces;

namespace MusicCatalog.Models
{
    public class Collection : IMyName
    {
        public string Name { get; set; }
        public IEnumerable<Song> Songs { get; set; }
        public override string ToString() { return "Collection: \"" + Name + "\""; }
    }
}
