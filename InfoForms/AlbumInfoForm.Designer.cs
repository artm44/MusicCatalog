
namespace MusicCatalog.InfoForms
{
    partial class AlbumInfoForm
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
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.listBoxArtist = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTracks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBoxTracks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTracks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTracks.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.ItemHeight = 21;
            this.listBoxTracks.Location = new System.Drawing.Point(20, 109);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.Size = new System.Drawing.Size(324, 273);
            this.listBoxTracks.TabIndex = 18;
            this.listBoxTracks.SelectedIndexChanged += new System.EventHandler(this.listBoxTracks_SelectedIndexChanged);
            // 
            // listBoxArtist
            // 
            this.listBoxArtist.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBoxArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxArtist.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArtist.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxArtist.FormattingEnabled = true;
            this.listBoxArtist.ItemHeight = 21;
            this.listBoxArtist.Location = new System.Drawing.Point(20, 62);
            this.listBoxArtist.Name = "listBoxArtist";
            this.listBoxArtist.Size = new System.Drawing.Size(324, 21);
            this.listBoxArtist.TabIndex = 17;
            this.listBoxArtist.SelectedIndexChanged += new System.EventHandler(this.listBoxArtist_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 40);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "label1";
            // 
            // labelTracks
            // 
            this.labelTracks.AutoSize = true;
            this.labelTracks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTracks.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTracks.Location = new System.Drawing.Point(17, 85);
            this.labelTracks.Name = "labelTracks";
            this.labelTracks.Size = new System.Drawing.Size(71, 21);
            this.labelTracks.TabIndex = 19;
            this.labelTracks.Text = "Tracks:";
            // 
            // AlbumInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(369, 397);
            this.Controls.Add(this.labelTracks);
            this.Controls.Add(this.listBoxTracks);
            this.Controls.Add(this.listBoxArtist);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AlbumInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumInfo";
            this.Load += new System.EventHandler(this.AlbumInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MyFunc()
        {
            this.labelName.Text = album.Name;
            this.listBoxArtist.Items.Insert(0, album.Artist);
            int ind = 0;
            foreach (var song in album.Songs)
                this.listBoxTracks.Items.Insert(ind++, song);
        }
        #endregion
        private System.Windows.Forms.ListBox listBoxTracks;
        private System.Windows.Forms.ListBox listBoxArtist;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTracks;
    }
}