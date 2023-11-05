using System;
using System.Windows.Forms;
using MusicCatalog.Models;

namespace MusicCatalog.InfoForms
{
    public partial class AlbumInfoForm : Form
    {
        private Album album;
        public AlbumInfoForm(Album album)
        {
            this.album = album;
            InitializeComponent();
            MyFunc();
        }

        private void AlbumInfoForm_Load(object sender, EventArgs e)
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

        private void listBoxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTracks.SelectedItem == null)
                return;
            var song = listBoxTracks.SelectedItem as MusicCatalog.Models.Song;
            SongInfoForm songInfo = new SongInfoForm(song);
            songInfo.Show();
            this.Hide();
        }
    }
}
