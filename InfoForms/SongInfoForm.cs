using System;
using System.Windows.Forms;
using MusicCatalog.Models;

namespace MusicCatalog.InfoForms
{
    public partial class SongInfoForm : Form
    {
        Song song;
        public SongInfoForm(Song song)
        {
            this.song = song;
            InitializeComponent();
            MyFunc();
        }

        private void SongInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArtist.SelectedItem == null)
                return;
            var artist = listBoxArtist.SelectedItem as MusicCatalog.Models.Artist;
            ArtistInfoForm artistInfo = new ArtistInfoForm(artist);
            artistInfo.Show();
            this.Hide();
        }

        private void listBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbum.SelectedItem == null)
                return;
            var album = listBoxAlbum.SelectedItem as MusicCatalog.Models.Album;
            AlbumInfoForm albumInfo = new AlbumInfoForm(album);
            albumInfo.Show();
            this.Hide();
        }
    }
}
