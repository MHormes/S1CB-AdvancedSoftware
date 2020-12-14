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
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.lbxAllUsers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsToAdd)).BeginInit();
            this.tpUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSongs);
            this.tabControl1.Controls.Add(this.tpUsers);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "New user name";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "New address";
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
    }
}

