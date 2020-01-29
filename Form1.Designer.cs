namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.checkSong = new System.Windows.Forms.Timer(this.components);
            this.nowPlayingArtist = new System.Windows.Forms.Label();
            this.searchSong = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.PictureBox();
            this.nowPlayingSong = new System.Windows.Forms.Label();
            this.npLink = new System.Windows.Forms.Button();
            this.clipUpdate = new System.Windows.Forms.Timer(this.components);
            this.searchInput = new System.Windows.Forms.TextBox();
            this.goToLink = new System.Windows.Forms.Button();
            this.cleanLinkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // checkSong
            // 
            this.checkSong.Enabled = true;
            this.checkSong.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nowPlayingArtist
            // 
            this.nowPlayingArtist.AutoSize = true;
            this.nowPlayingArtist.CausesValidation = false;
            this.nowPlayingArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nowPlayingArtist.Location = new System.Drawing.Point(229, 92);
            this.nowPlayingArtist.Name = "nowPlayingArtist";
            this.nowPlayingArtist.Size = new System.Drawing.Size(85, 37);
            this.nowPlayingArtist.TabIndex = 3;
            this.nowPlayingArtist.Text = "Artist";
            // 
            // searchSong
            // 
            this.searchSong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchSong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchSong.Location = new System.Drawing.Point(0, 273);
            this.searchSong.Name = "searchSong";
            this.searchSong.Size = new System.Drawing.Size(557, 23);
            this.searchSong.TabIndex = 4;
            this.searchSong.Text = "Search";
            this.searchSong.UseVisualStyleBackColor = true;
            this.searchSong.Click += new System.EventHandler(this.searchSong_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Purple;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(557, 19);
            this.header.TabIndex = 5;
            this.header.TabStop = false;
            // 
            // nowPlayingSong
            // 
            this.nowPlayingSong.AutoSize = true;
            this.nowPlayingSong.CausesValidation = false;
            this.nowPlayingSong.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingSong.ForeColor = System.Drawing.Color.Silver;
            this.nowPlayingSong.Location = new System.Drawing.Point(174, 55);
            this.nowPlayingSong.Name = "nowPlayingSong";
            this.nowPlayingSong.Size = new System.Drawing.Size(140, 37);
            this.nowPlayingSong.TabIndex = 0;
            this.nowPlayingSong.Text = "Song Title";
            this.nowPlayingSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npLink
            // 
            this.npLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.npLink.Location = new System.Drawing.Point(0, 250);
            this.npLink.Name = "npLink";
            this.npLink.Size = new System.Drawing.Size(557, 23);
            this.npLink.TabIndex = 7;
            this.npLink.Text = "Now Playing Link";
            this.npLink.UseVisualStyleBackColor = true;
            this.npLink.Click += new System.EventHandler(this.npLink_Click);
            // 
            // clipUpdate
            // 
            this.clipUpdate.Enabled = true;
            this.clipUpdate.Interval = 1000;
            this.clipUpdate.Tick += new System.EventHandler(this.clipUpdate_Tick);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(224, 178);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(100, 20);
            this.searchInput.TabIndex = 9;
            this.searchInput.Text = "Search";
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // goToLink
            // 
            this.goToLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToLink.Location = new System.Drawing.Point(0, 227);
            this.goToLink.Name = "goToLink";
            this.goToLink.Size = new System.Drawing.Size(557, 23);
            this.goToLink.TabIndex = 11;
            this.goToLink.Text = "Follow clip link";
            this.goToLink.UseVisualStyleBackColor = true;
            this.goToLink.Click += new System.EventHandler(this.goToLink_Click);
            // 
            // cleanLinkBtn
            // 
            this.cleanLinkBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cleanLinkBtn.Location = new System.Drawing.Point(0, 204);
            this.cleanLinkBtn.Name = "cleanLinkBtn";
            this.cleanLinkBtn.Size = new System.Drawing.Size(557, 23);
            this.cleanLinkBtn.TabIndex = 12;
            this.cleanLinkBtn.Text = "Clean Links";
            this.cleanLinkBtn.UseVisualStyleBackColor = true;
            this.cleanLinkBtn.Click += new System.EventHandler(this.cleanLinkBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.searchSong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(557, 296);
            this.Controls.Add(this.cleanLinkBtn);
            this.Controls.Add(this.goToLink);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.npLink);
            this.Controls.Add(this.header);
            this.Controls.Add(this.searchSong);
            this.Controls.Add(this.nowPlayingArtist);
            this.Controls.Add(this.nowPlayingSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer checkSong;
        private System.Windows.Forms.Label nowPlayingArtist;
        private System.Windows.Forms.Button searchSong;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Label nowPlayingSong;
        private System.Windows.Forms.Button npLink;
        private System.Windows.Forms.Timer clipUpdate;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button goToLink;
        private System.Windows.Forms.Button cleanLinkBtn;
    }
}

