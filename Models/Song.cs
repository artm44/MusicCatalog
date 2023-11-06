using MusicCatalog.Models.Interfaces;

namespace MusicCatalog.Models
{
    public class Song : IName
    {
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public override string ToString() { return "Track: \"" + Name + "\""; }
    }
}
