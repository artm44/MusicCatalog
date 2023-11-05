using System;
using System.Windows.Forms;
using MusicCatalog.Models;

namespace MusicCatalog.InfoForms
{
    public partial class CollectionInfoForm : Form
    {
        private Collection collection;
        public CollectionInfoForm(Collection collection)
        {
            this.collection = collection;
            InitializeComponent();
            MyFunc();
        }

        private void CollectionInfoForm_Load(object sender, EventArgs e)
        {

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
