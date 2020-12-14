namespace StreamingMusicService
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSongs = new System.Windows.Forms.TabPage();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.tbxSongToAdd = new System.Windows.Forms.TextBox();
            this.tbxArtistToAdd = new System.Windows.Forms.TextBox();
            this.nudSecondsToAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllSongs = new System.Windows.Forms.Button();
            this.lbxAllSongs = new System.Windows.Forms.ListBox();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbxEmailToAdd = new System.Windows.Forms.TextBox();
            this.tbxAdressToAdd = new System.Windows.Forms.TextBox();
            this.tbxUserToAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.lbxAllUsers = new System.Windows.Forms.ListBox();
            this.tpFavorites = new System.Windows.Forms.TabPage();
            this.btnAddFavorite = new System.Windows.Forms.Button();
            this.tbxUserToAddFavo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbxSongChoise = new System.Windows.Forms.ListBox();
            this.btnShowFavorites = new System.Windows.Forms.Button();
            this.lbxFavorites = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsToAdd)).BeginInit();
            this.tpUsers.SuspendLayout();
            this.tpFavorites.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSongs);
            this.tabControl1.Controls.Add(this.tpUsers);
            this.tabControl1.Controls.Add(this.tpFavorites);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSongs
            // 
            this.tpSongs.Controls.Add(this.btnAddSong);
            this.tpSongs.Controls.Add(this.tbxSongToAdd);
            this.tpSongs.Controls.Add(this.tbxArtistToAdd);
            this.tpSongs.Controls.Add(this.nudSecondsToAdd);
            this.tpSongs.Controls.Add(this.label3);
            this.tpSongs.Controls.Add(this.label2);
            this.tpSongs.Controls.Add(this.label1);
            this.tpSongs.Controls.Add(this.btnShowAllSongs);
            this.tpSongs.Controls.Add(this.lbxAllSongs);
            this.tpSongs.Location = new System.Drawing.Point(4, 22);
            this.tpSongs.Name = "tpSongs";
            this.tpSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tpSongs.Size = new System.Drawing.Size(767, 399);
            this.tpSongs.TabIndex = 0;
            this.tpSongs.Text = "Songs";
            this.tpSongs.UseVisualStyleBackColor = true;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(385, 104);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(247, 23);
            this.btnAddSong.TabIndex = 8;
            this.btnAddSong.Text = "Add song to the list";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // tbxSongToAdd
            // 
            this.tbxSongToAdd.Location = new System.Drawing.Point(532, 7);
            this.tbxSongToAdd.Name = "tbxSongToAdd";
            this.tbxSongToAdd.Size = new System.Drawing.Size(100, 20);
            this.tbxSongToAdd.TabIndex = 7;
            // 
            // tbxArtistToAdd
            // 
            this.tbxArtistToAdd.Location = new System.Drawing.Point(532, 43);
            this.tbxArtistToAdd.Name = "tbxArtistToAdd";
            this.tbxArtistToAdd.Size = new System.Drawing.Size(100, 20);
            this.tbxArtistToAdd.TabIndex = 6;
            // 
            // nudSecondsToAdd
            // 
            this.nudSecondsToAdd.Location = new System.Drawing.Point(532, 78);
            this.nudSecondsToAdd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSecondsToAdd.Name = "nudSecondsToAdd";
            this.nudSecondsToAdd.Size = new System.Drawing.Size(100, 20);
            this.nudSecondsToAdd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length to add (seconds:)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artist to add:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name to add:";
            // 
            // btnShowAllSongs
            // 
            this.btnShowAllSongs.Location = new System.Drawing.Point(6, 354);
            this.btnShowAllSongs.Name = "btnShowAllSongs";
            this.btnShowAllSongs.Size = new System.Drawing.Size(329, 23);
            this.btnShowAllSongs.TabIndex = 1;
            this.btnShowAllSongs.Text = "Show all songs";
            this.btnShowAllSongs.UseVisualStyleBackColor = true;
            this.btnShowAllSongs.Click += new System.EventHandler(this.btnShowAllSongs_Click);
            // 
            // lbxAllSongs
            // 
            this.lbxAllSongs.FormattingEnabled = true;
            this.lbxAllSongs.Location = new System.Drawing.Point(7, 6);
            this.lbxAllSongs.Name = "lbxAllSongs";
            this.lbxAllSongs.Size = new System.Drawing.Size(328, 342);
            this.lbxAllSongs.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.btnAddUser);
            this.tpUsers.Controls.Add(this.tbxEmailToAdd);
            this.tpUsers.Controls.Add(this.tbxAdressToAdd);
            this.tpUsers.Controls.Add(this.tbxUserToAdd);
            this.tpUsers.Controls.Add(this.label6);
            this.tpUsers.Controls.Add(this.label5);
            this.tpUsers.Controls.Add(this.label4);
            this.tpUsers.Controls.Add(this.btnShowAllUsers);
            this.tpUsers.Controls.Add(this.lbxAllUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(767, 399);
            this.tpUsers.TabIndex = 1;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(452, 111);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(201, 23);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add new user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbxEmailToAdd
            // 
            this.tbxEmailToAdd.Location = new System.Drawing.Point(452, 44);
            this.tbxEmailToAdd.Name = "tbxEmailToAdd";
            this.tbxEmailToAdd.Size = new System.Drawing.Size(201, 20);
            this.tbxEmailToAdd.TabIndex = 9;
            // 
            // tbxAdressToAdd
            // 
            this.tbxAdressToAdd.Location = new System.Drawing.Point(452, 73);
            this.tbxAdressToAdd.Name = "tbxAdressToAdd";
            this.tbxAdressToAdd.Size = new System.Drawing.Size(201, 20);
            this.tbxAdressToAdd.TabIndex = 8;
            // 
            // tbxUserToAdd
            // 
            this.tbxUserToAdd.Location = new System.Drawing.Point(452, 18);
            this.tbxUserToAdd.Name = "tbxUserToAdd";
            this.tbxUserToAdd.Size = new System.Drawing.Size(201, 20);
            this.tbxUserToAdd.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "New address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "New email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "New user name";
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Location = new System.Drawing.Point(2, 354);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(329, 23);
            this.btnShowAllUsers.TabIndex = 3;
            this.btnShowAllUsers.Text = "Show all users";
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // lbxAllUsers
            // 
            this.lbxAllUsers.FormattingEnabled = true;
            this.lbxAllUsers.Location = new System.Drawing.Point(3, 6);
            this.lbxAllUsers.Name = "lbxAllUsers";
            this.lbxAllUsers.Size = new System.Drawing.Size(328, 342);
            this.lbxAllUsers.TabIndex = 2;
            // 
            // tpFavorites
            // 
            this.tpFavorites.Controls.Add(this.lbxFavorites);
            this.tpFavorites.Controls.Add(this.btnShowFavorites);
            this.tpFavorites.Controls.Add(this.btnAddFavorite);
            this.tpFavorites.Controls.Add(this.tbxUserToAddFavo);
            this.tpFavorites.Controls.Add(this.label9);
            this.tpFavorites.Controls.Add(this.button2);
            this.tpFavorites.Controls.Add(this.lbxSongChoise);
            this.tpFavorites.Location = new System.Drawing.Point(4, 22);
            this.tpFavorites.Name = "tpFavorites";
            this.tpFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.tpFavorites.Size = new System.Drawing.Size(767, 399);
            this.tpFavorites.TabIndex = 2;
            this.tpFavorites.Text = "Favorites";
            this.tpFavorites.UseVisualStyleBackColor = true;
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.Location = new System.Drawing.Point(417, 44);
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(201, 23);
            this.btnAddFavorite.TabIndex = 19;
            this.btnAddFavorite.Text = "Add favorite";
            this.btnAddFavorite.UseVisualStyleBackColor = true;
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // tbxUserToAddFavo
            // 
            this.tbxUserToAddFavo.Location = new System.Drawing.Point(417, 18);
            this.tbxUserToAddFavo.Name = "tbxUserToAddFavo";
            this.tbxUserToAddFavo.Size = new System.Drawing.Size(201, 20);
            this.tbxUserToAddFavo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "User to add to";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Show all songs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbxSongChoise
            // 
            this.lbxSongChoise.FormattingEnabled = true;
            this.lbxSongChoise.Location = new System.Drawing.Point(3, 6);
            this.lbxSongChoise.Name = "lbxSongChoise";
            this.lbxSongChoise.Size = new System.Drawing.Size(328, 342);
            this.lbxSongChoise.TabIndex = 11;
            // 
            // btnShowFavorites
            // 
            this.btnShowFavorites.Location = new System.Drawing.Point(426, 330);
            this.btnShowFavorites.Name = "btnShowFavorites";
            this.btnShowFavorites.Size = new System.Drawing.Size(201, 23);
            this.btnShowFavorites.TabIndex = 20;
            this.btnShowFavorites.Text = "Show all favorites of this user";
            this.btnShowFavorites.UseVisualStyleBackColor = true;
            this.btnShowFavorites.Click += new System.EventHandler(this.btnShowFavorites_Click);
            // 
            // lbxFavorites
            // 
            this.lbxFavorites.FormattingEnabled = true;
            this.lbxFavorites.Location = new System.Drawing.Point(340, 73);
            this.lbxFavorites.Name = "lbxFavorites";
            this.lbxFavorites.Size = new System.Drawing.Size(287, 251);
            this.lbxFavorites.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpSongs.ResumeLayout(false);
            this.tpSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsToAdd)).EndInit();
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            this.tpFavorites.ResumeLayout(false);
            this.tpFavorites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSongs;
        private System.Windows.Forms.ListBox lbxAllSongs;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.Button btnShowAllSongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox tbxSongToAdd;
        private System.Windows.Forms.TextBox tbxArtistToAdd;
        private System.Windows.Forms.NumericUpDown nudSecondsToAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.ListBox lbxAllUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox tbxEmailToAdd;
        private System.Windows.Forms.TextBox tbxAdressToAdd;
        private System.Windows.Forms.TextBox tbxUserToAdd;
        private System.Windows.Forms.TabPage tpFavorites;
        private System.Windows.Forms.Button btnShowFavorites;
        private System.Windows.Forms.Button btnAddFavorite;
        private System.Windows.Forms.TextBox tbxUserToAddFavo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbxSongChoise;
        private System.Windows.Forms.ListBox lbxFavorites;
    }
}

