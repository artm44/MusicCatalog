using System;
using System.Windows.Forms;
using MusicCatalog.Models;

namespace MusicCatalog.InfoForms
{
    public partial class ArtistInfoForm : Form
    {
        private Artist artist;
        private System.Windows.Forms.Button[] ChooseButtons;
        public ArtistInfoForm(Artist artist)
        {
            this.artist = artist;
            InitializeComponent();
            MyFunc();
        }

        private void ArtistInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeColor(string name)
        {
            foreach (var button in ChooseButtons)
            {
                if (button.Name == name)
                    button.BackColor = System.Drawing.SystemColors.WindowFrame;
                else
                    button.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            if (button.BackColor != System.Drawing.SystemColors.ActiveCaption)
            {
                ChangeColor(button.Name);
                listBox1.Items.Clear();
                int ind = 0;
                if(button.Name=="buttonAlbums")
                { 
                    foreach (var item in artist.Albums)
                        listBox1.Items.Insert(ind++, item);
                }
                else
                {
                    foreach (var item in artist.Songs)
                        listBox1.Items.Insert(ind++, item);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string selectedItem = listBox1.SelectedItem.GetType().ToString();
            if (selectedItem == "MusicCatalog.Models.Song")
            {
                var song = listBox1.SelectedItem as MusicCatalog.Models.Song;
                SongInfoForm songInfo = new SongInfoForm(song);
                songInfo.Show();
            }
            else
            {
                var album = listBox1.SelectedItem as MusicCatalog.Models.Album;
                AlbumInfoForm albumInfo = new AlbumInfoForm(album);
                albumInfo.Show();
            }
            this.Hide();
        }

    }
}
