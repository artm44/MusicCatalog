
namespace MusicCatalog
{
    partial class HomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        ///
        /// Мои классы и поля
        ///

        

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFinded = new System.Windows.Forms.ListBox();
            this.textFind = new System.Windows.Forms.TextBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonTracks = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonArtists = new System.Windows.Forms.Button();
            this.buttonCollections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFinded
            // 
            this.listFinded.BackColor = System.Drawing.SystemColors.ControlText;
            this.listFinded.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFinded.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listFinded.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFinded.ForeColor = System.Drawing.SystemColors.Window;
            this.listFinded.FormattingEnabled = true;
            this.listFinded.ItemHeight = 21;
            this.listFinded.Location = new System.Drawing.Point(0, 177);
            this.listFinded.Name = "listFinded";
            this.listFinded.Size = new System.Drawing.Size(800, 273);
            this.listFinded.TabIndex = 0;
            this.listFinded.Visible = false;
            this.listFinded.SelectedIndexChanged += new System.EventHandler(this.listFinded_SelectedIndexChanged);
            // 
            // textFind
            // 
            this.textFind.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFind.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFind.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textFind.Location = new System.Drawing.Point(98, 27);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(604, 31);
            this.textFind.TabIndex = 1;
            this.textFind.TabStop = false;
            this.textFind.Text = "Favorite tracks, albums, artists and collections";
            this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
            this.textFind.Enter += new System.EventHandler(this.textFind_Enter);
            this.textFind.Leave += new System.EventHandler(this.textFind_Leave);
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAll.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(98, 68);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(116, 48);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // buttonTracks
            // 
            this.buttonTracks.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTracks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTracks.Location = new System.Drawing.Point(220, 68);
            this.buttonTracks.Name = "buttonTracks";
            this.buttonTracks.Size = new System.Drawing.Size(116, 48);
            this.buttonTracks.TabIndex = 4;
            this.buttonTracks.Text = "Tracks";
            this.buttonTracks.UseVisualStyleBackColor = false;
            this.buttonTracks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAlbums.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbums.Location = new System.Drawing.Point(342, 68);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(116, 48);
            this.buttonAlbums.TabIndex = 5;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // buttonArtists
            // 
            this.buttonArtists.BackColor = System.Drawing.SystemColors.Window;
            this.buttonArtists.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArtists.Location = new System.Drawing.Point(464, 68);
            this.buttonArtists.Name = "buttonArtists";
            this.buttonArtists.Size = new System.Drawing.Size(116, 48);
            this.buttonArtists.TabIndex = 6;
            this.buttonArtists.Text = "Artists";
            this.buttonArtists.UseVisualStyleBackColor = false;
            this.buttonArtists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // buttonCollections
            // 
            this.buttonCollections.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCollections.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollections.Location = new System.Drawing.Point(586, 68);
            this.buttonCollections.Name = "buttonCollections";
            this.buttonCollections.Size = new System.Drawing.Size(116, 48);
            this.buttonCollections.TabIndex = 7;
            this.buttonCollections.Text = "Collections";
            this.buttonCollections.UseVisualStyleBackColor = false;
            this.buttonCollections.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCollections);
            this.Controls.Add(this.buttonArtists);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.buttonTracks);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.textFind);
            this.Controls.Add(this.listFinded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void MyFunc()
        {
            ChooseButtons = new System.Windows.Forms.Button[] { this.buttonAll, this.buttonTracks, this.buttonAlbums, this.buttonArtists, this.buttonCollections};
        }

        private System.Windows.Forms.ListBox listFinded;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonTracks;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonArtists;
        private System.Windows.Forms.Button buttonCollections;
    }
}

