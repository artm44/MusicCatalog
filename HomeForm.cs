using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicCatalog.Models;
using MusicCatalog.Models.InterfaceImplementations;
using MusicCatalog.Models.Interfaces;
using MusicCatalog.InfoForms;

namespace MusicCatalog
{
    public partial class HomeForm : Form
    {
        private ICatalog _catalog;

        private System.Windows.Forms.Button[] ChooseButtons;
        public HomeForm(ICatalog catalog)
        {
            _catalog = catalog;

            InitializeComponent();

            MyFunc();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApplyFilter<T> (bool flag, IEnumerable<T> collection) where T : IName
        {
            if (flag)
                listFinded.Items.Clear();
            IFilter<T> filter = new FilterByName<T>(textFind.Text == "Favorite tracks, albums, artists and collections" ? "" : textFind.Text);
            int ind = listFinded.Items.Count;
            foreach (var item in filter.Filter(collection))
            {
                listFinded.Items.Insert(ind++, item);
            }
        }

        private int IndexOfChoosenButton()
        {
            int ind = 0;
            foreach( var button in ChooseButtons)
            {
                if (button.BackColor == System.Drawing.SystemColors.WindowFrame)
                    return ind;
                ind++;
            }
            return 0;
        }

        private void Find()
        {
            
            listFinded.Visible = true;
            switch (IndexOfChoosenButton())
            {
                case 0:
                    ApplyFilter<Song>(true, _catalog.Songs);
                    ApplyFilter<Album>(false, _catalog.Albums);
                    ApplyFilter<Artist>(false, _catalog.Artists);
                    ApplyFilter<Collection>(false, _catalog.Collections);
                    break;
                case 1:
                    ApplyFilter<Song>(true, _catalog.Songs);
                    break;
                case 2:
                    ApplyFilter<Album>(true, _catalog.Albums);
                    break;
                case 3:
                    ApplyFilter<Artist>(true, _catalog.Artists);
                    break;
                case 4:
                    ApplyFilter<Collection>(true, _catalog.Collections);
                    break;
            }
        }

        private void ChangeColor(string name)
        {
            foreach(var button in ChooseButtons)
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
            ChangeColor(button.Name);
            Find();
        }

        private void listFinded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFinded.SelectedItem == null)
                return;
            string selectedItem = listFinded.SelectedItem.GetType().ToString();
            if(selectedItem=="MusicCatalog.Models.Song")
            {
                var song = listFinded.SelectedItem as MusicCatalog.Models.Song;
                SongInfoForm songInfo = new SongInfoForm(song);
                songInfo.Show();
            }else if (selectedItem == "MusicCatalog.Models.Artist")
            {
                var artist = listFinded.SelectedItem as MusicCatalog.Models.Artist;
                ArtistInfoForm artistInfo = new ArtistInfoForm(artist);
                artistInfo.Show();
            }
            else if (selectedItem == "MusicCatalog.Models.Album")
            {
                var album = listFinded.SelectedItem as MusicCatalog.Models.Album;
                AlbumInfoForm albumInfo = new AlbumInfoForm(album);
                albumInfo.Show();
            }
            else if (selectedItem == "MusicCatalog.Models.Collection")
            {
                var collection = listFinded.SelectedItem as MusicCatalog.Models.Collection;
                CollectionInfoForm collectionInfo = new CollectionInfoForm(collection);
                collectionInfo.Show();
            }
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            textFind.ForeColor = System.Drawing.SystemColors.Window;
            Find();
        }

        private void textFind_Enter(object sender, EventArgs e)
        {
            if (textFind.Text == "Favorite tracks, albums, artists and collections")
            {
                textFind.Text = "";
                textFind.ForeColor = System.Drawing.SystemColors.Window;
            }
        }

        private void textFind_Leave(object sender, EventArgs e)
        {
            if (textFind.Text == "")
            {
                textFind.Text = "Favorite tracks, albums, artists and collections";
                textFind.ForeColor = System.Drawing.SystemColors.ScrollBar;
            }
        }
    }
}
