using System.Collections.Generic;
using MusicCatalog.Models.Interfaces;

namespace MusicCatalog.Models
{
    public class Album : IMyName
    {
        public Artist Artist { get; set; }
        public IEnumerable<Song> Songs { get; set; }
        public string Name { get; set; }
        public override string ToString () { return "Album: \"" + Name + "\""; }
    }
}
