
namespace MusicCatalog.InfoForms
{
    partial class SongInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxArtist = new System.Windows.Forms.ListBox();
            this.listBoxAlbum = new System.Windows.Forms.ListBox();
            this.labelLanguge = new System.Windows.Forms.Label();
            this.labelLanguageName = new System.Windows.Forms.Label();
            this.labelGenreName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(14, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 40);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "label1";
            // 
            // listBoxArtist
            // 
            this.listBoxArtist.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBoxArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxArtist.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArtist.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxArtist.FormattingEnabled = true;
            this.listBoxArtist.ItemHeight = 21;
            this.listBoxArtist.Location = new System.Drawing.Point(21, 67);
            this.listBoxArtist.Name = "listBoxArtist";
            this.listBoxArtist.Size = new System.Drawing.Size(324, 21);
            this.listBoxArtist.TabIndex = 9;
            this.listBoxArtist.SelectedIndexChanged += new System.EventHandler(this.listBoxArtist_SelectedIndexChanged);
            // 
            // listBoxAlbum
            // 
            this.listBoxAlbum.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAlbum.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbum.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxAlbum.FormattingEnabled = true;
            this.listBoxAlbum.ItemHeight = 21;
            this.listBoxAlbum.Location = new System.Drawing.Point(21, 95);
            this.listBoxAlbum.Name = "listBoxAlbum";
            this.listBoxAlbum.Size = new System.Drawing.Size(324, 21);
            this.listBoxAlbum.TabIndex = 11;
            this.listBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbum_SelectedIndexChanged);
            // 
            // labelLanguge
            // 
            this.labelLanguge.AutoSize = true;
            this.labelLanguge.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguge.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLanguge.Location = new System.Drawing.Point(17, 122);
            this.labelLanguge.Name = "labelLanguge";
            this.labelLanguge.Size = new System.Drawing.Size(95, 21);
            this.labelLanguge.TabIndex = 12;
            this.labelLanguge.Text = "Language:";
            // 
            // labelLanguageName
            // 
            this.labelLanguageName.AutoSize = true;
            this.labelLanguageName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguageName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLanguageName.Location = new System.Drawing.Point(110, 122);
            this.labelLanguageName.Name = "labelLanguageName";
            this.labelLanguageName.Size = new System.Drawing.Size(60, 21);
            this.labelLanguageName.TabIndex = 13;
            this.labelLanguageName.Text = "label1";
            // 
            // labelGenreName
            // 
            this.labelGenreName.AutoSize = true;
            this.labelGenreName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenreName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelGenreName.Location = new System.Drawing.Point(83, 144);
            this.labelGenreName.Name = "labelGenreName";
            this.labelGenreName.Size = new System.Drawing.Size(60, 21);
            this.labelGenreName.TabIndex = 15;
            this.labelGenreName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(17, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Genre:";
            // 
            // SongInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(387, 178);
            this.Controls.Add(this.labelGenreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLanguageName);
            this.Controls.Add(this.labelLanguge);
            this.Controls.Add(this.listBoxAlbum);
            this.Controls.Add(this.listBoxArtist);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SongInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongInfo";
            this.Load += new System.EventHandler(this.SongInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MyFunc()
        {
            this.labelName.Text = song.Name;
            this.labelLanguageName.Text = song.Language;
            this.labelGenreName.Text = song.Genre;
            this.listBoxArtist.Items.Insert(0, song.Artist);
            this.listBoxAlbum.Items.Insert(0, song.Album);
        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxArtist;
        private System.Windows.Forms.ListBox listBoxAlbum;
        private System.Windows.Forms.Label labelLanguge;
        private System.Windows.Forms.Label labelLanguageName;
        private System.Windows.Forms.Label labelGenreName;
        private System.Windows.Forms.Label label2;
    }
}