using System.Collections.Generic;
using System.Linq;
using System.Data;
using MusicCatalog.Models.Interfaces;


namespace MusicCatalog.Models
{
    public class Catalog : ICatalog
    {
        public IEnumerable<Song> Songs { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Collection> Collections { get; set; }
        public Catalog(IDataProvider dataProvider) 
        {
            DataTable dataTable = dataProvider.GetData();

            //Artists
            {
                var query = dataTable.AsEnumerable()
                            .Select(row => new
                            {
                                name = row.Field<string>("name_of_artist")
                            })
                            .Distinct();
                var artists = new List<Artist>();
                foreach (var artist in query)
                {
                    artists.Add(new Artist()
                    {
                        Name = artist.name
                    });
                }

                Artists = artists;
            }

            //Albums
            {
                var albums = new List<Album>();
                foreach (var artist in Artists)
                {
                    var albums_of_artist = new List<Album>();
                    var query = dataTable.AsEnumerable()
                            .Where(x => x.Field<string>("name_of_artist") == artist.Name)
                            .Select(x => new
                            {
                                name = x.Field<string>("name_of_album")
                            })
                            .Distinct();


                    foreach (var album in query)
                    {
                        albums_of_artist.Add(new Album()
                        {
                            Name = album.name,
                            Artist = artist
                        });
                    }

                    artist.Albums = albums_of_artist;

                    foreach (var album in albums_of_artist)
                    {
                        albums.Add(album);
                    }
                }
                Albums = albums;
            }

            // Songs
            {
                var songs = new List<Song>();
                foreach (var artist in Artists) {
                    var songs_of_artist = new List<Song>();
                    foreach (var album in artist.Albums)
                    {
                        var songs_of_album = new List<Song>();
                        var query = dataTable.AsEnumerable()
                                .Where(x => x.Field<string>("name_of_album") == album.Name)
                                .Select(x => new
                                {
                                    name = x.Field<string>("name_of_song"),
                                    genre = x.Field<string>("name_of_genre"),
                                    language = x.Field<string>("language_of_song")
                                });


                        foreach (var song in query)
                        {
                            songs_of_album.Add(new Song()
                            {
                                Name = song.name,
                                Artist = album.Artist,
                                Album = album,
                                Genre = song.genre,
                                Language = song.language
                            });
                        }

                        album.Songs = songs_of_album;
    
                        foreach (var song in songs_of_album)
                        {
                            songs.Add(song);
                            songs_of_artist.Add(song);
                        }
                    }
                    artist.Songs = songs_of_artist;
                }
                Songs = songs;
            }

            //Collections
            {
                var collections = new List<Collection>();
                //by Genre
                {
                    var query = dataTable.AsEnumerable()
                            .Select(row => new
                            {
                                name = row.Field<string>("name_of_genre")
                            })
                            .Distinct();
                    foreach (var genre in query)
                    {
                        Collection collection = new Collection
                        {
                            Name = genre.name,
                            Songs = Songs.Where(x => x.Genre == genre.name)
                        };
                        collections.Add(collection);
                    }
                }
                //by Language
                {
                    var query = dataTable.AsEnumerable()
                            .Select(row => new
                            {
                                name = row.Field<string>("language_of_song")
                            })
                            .Distinct();
                    foreach (var language in query)
                    {
                        Collection collection = new Collection
                        {
                            Name = language.name,
                            Songs = Songs.Where(x => x.Language == language.name)
                        };
                        collections.Add(collection);
                    }
                }
                Collections = collections;
            }
        }
    }
}
