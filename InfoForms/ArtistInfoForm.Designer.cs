
namespace MusicCatalog.InfoForms
{
    partial class ArtistInfoForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonTracks = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(0, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 340);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAlbums.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbums.Location = new System.Drawing.Point(262, 79);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(198, 55);
            this.buttonAlbums.TabIndex = 6;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // buttonTracks
            // 
            this.buttonTracks.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonTracks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTracks.Location = new System.Drawing.Point(12, 79);
            this.buttonTracks.Name = "buttonTracks";
            this.buttonTracks.Size = new System.Drawing.Size(198, 55);
            this.buttonTracks.TabIndex = 5;
            this.buttonTracks.Text = "Tracks";
            this.buttonTracks.UseVisualStyleBackColor = false;
            this.buttonTracks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(12, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 40);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "label1";
            // 
            // ArtistInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(472, 480);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.buttonTracks);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ArtistInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtistInfo";
            this.Load += new System.EventHandler(this.ArtistInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void MyFunc()
        {
            ChooseButtons = new System.Windows.Forms.Button[] { this.buttonTracks, this.buttonAlbums };
            this.labelName.Text = artist.Name;
            int ind = 0;
            foreach (var song in artist.Songs)
                this.listBox1.Items.Insert(ind++, song);
        }

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonTracks;
        private System.Windows.Forms.Label labelName;
    }
}