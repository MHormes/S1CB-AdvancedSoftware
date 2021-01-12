namespace AppPCS2June2019
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
            this.btnFillMagazineWithSomeNewsitems = new System.Windows.Forms.Button();
            this.btnAddNewsitem = new System.Windows.Forms.Button();
            this.gbAddNewsItem = new System.Windows.Forms.GroupBox();
            this.cbNewstype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstLine = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveNewsItem = new System.Windows.Forms.Button();
            this.gbAddLineToNewsItem = new System.Windows.Forms.GroupBox();
            this.btnInsertLine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdNewsitem = new System.Windows.Forms.TextBox();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnShowInfoOfNewsitem = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.gbShowInfo = new System.Windows.Forms.GroupBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnShowGeneralInfoOfAllNewsitems = new System.Windows.Forms.Button();
            this.tbxFilterAuthor = new System.Windows.Forms.TextBox();
            this.btnShowFromAuthor = new System.Windows.Forms.Button();
            this.gbAddNewsItem.SuspendLayout();
            this.gbAddLineToNewsItem.SuspendLayout();
            this.gbShowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFillMagazineWithSomeNewsitems
            // 
            this.btnFillMagazineWithSomeNewsitems.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFillMagazineWithSomeNewsitems.Location = new System.Drawing.Point(22, 6);
            this.btnFillMagazineWithSomeNewsitems.Name = "btnFillMagazineWithSomeNewsitems";
            this.btnFillMagazineWithSomeNewsitems.Size = new System.Drawing.Size(299, 42);
            this.btnFillMagazineWithSomeNewsitems.TabIndex = 0;
            this.btnFillMagazineWithSomeNewsitems.Text = "fill magazine with some news-items";
            this.btnFillMagazineWithSomeNewsitems.UseVisualStyleBackColor = false;
            this.btnFillMagazineWithSomeNewsitems.Click += new System.EventHandler(this.btnFillMagazineWithSomeNewsitems_Click);
            // 
            // btnAddNewsitem
            // 
            this.btnAddNewsitem.BackColor = System.Drawing.Color.Violet;
            this.btnAddNewsitem.Location = new System.Drawing.Point(133, 117);
            this.btnAddNewsitem.Name = "btnAddNewsitem";
            this.btnAddNewsitem.Size = new System.Drawing.Size(143, 32);
            this.btnAddNewsitem.TabIndex = 1;
            this.btnAddNewsitem.Text = "add news-item";
            this.btnAddNewsitem.UseVisualStyleBackColor = false;
            this.btnAddNewsitem.Click += new System.EventHandler(this.btnAddNewsitem_Click);
            // 
            // gbAddNewsItem
            // 
            this.gbAddNewsItem.BackColor = System.Drawing.Color.Coral;
            this.gbAddNewsItem.Controls.Add(this.cbNewstype);
            this.gbAddNewsItem.Controls.Add(this.label3);
            this.gbAddNewsItem.Controls.Add(this.tbFirstLine);
            this.gbAddNewsItem.Controls.Add(this.tbAuthor);
            this.gbAddNewsItem.Controls.Add(this.tbTitle);
            this.gbAddNewsItem.Controls.Add(this.label2);
            this.gbAddNewsItem.Controls.Add(this.label1);
            this.gbAddNewsItem.Controls.Add(this.btnAddNewsitem);
            this.gbAddNewsItem.Location = new System.Drawing.Point(25, 54);
            this.gbAddNewsItem.Name = "gbAddNewsItem";
            this.gbAddNewsItem.Size = new System.Drawing.Size(296, 161);
            this.gbAddNewsItem.TabIndex = 3;
            this.gbAddNewsItem.TabStop = false;
            this.gbAddNewsItem.Text = "add/remove news-item";
            // 
            // cbNewstype
            // 
            this.cbNewstype.FormattingEnabled = true;
            this.cbNewstype.Items.AddRange(new object[] {
            "POLITICS",
            "SPORTS",
            "CULTURE",
            "REGIONAL",
            "GOSSIP"});
            this.cbNewstype.Location = new System.Drawing.Point(18, 122);
            this.cbNewstype.Name = "cbNewstype";
            this.cbNewstype.Size = new System.Drawing.Size(100, 45);
            this.cbNewstype.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "first line";
            // 
            // tbFirstLine
            // 
            this.tbFirstLine.Location = new System.Drawing.Point(87, 86);
            this.tbFirstLine.Name = "tbFirstLine";
            this.tbFirstLine.Size = new System.Drawing.Size(189, 44);
            this.tbFirstLine.TabIndex = 6;
            this.tbFirstLine.Text = "Summer starts soon";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(87, 55);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(189, 44);
            this.tbAuthor.TabIndex = 5;
            this.tbAuthor.Text = "Bert van Gestel";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 23);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(189, 44);
            this.tbTitle.TabIndex = 4;
            this.tbTitle.Text = "Summer in Egypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "title";
            // 
            // btnRemoveNewsItem
            // 
            this.btnRemoveNewsItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRemoveNewsItem.Location = new System.Drawing.Point(21, 121);
            this.btnRemoveNewsItem.Name = "btnRemoveNewsItem";
            this.btnRemoveNewsItem.Size = new System.Drawing.Size(266, 31);
            this.btnRemoveNewsItem.TabIndex = 8;
            this.btnRemoveNewsItem.Text = "remove news-item";
            this.btnRemoveNewsItem.UseVisualStyleBackColor = false;
            this.btnRemoveNewsItem.Click += new System.EventHandler(this.btnRemoveNewsItem_Click);
            // 
            // gbAddLineToNewsItem
            // 
            this.gbAddLineToNewsItem.BackColor = System.Drawing.Color.Gold;
            this.gbAddLineToNewsItem.Controls.Add(this.btnRemoveNewsItem);
            this.gbAddLineToNewsItem.Controls.Add(this.btnInsertLine);
            this.gbAddLineToNewsItem.Controls.Add(this.label4);
            this.gbAddLineToNewsItem.Controls.Add(this.tbIdNewsitem);
            this.gbAddLineToNewsItem.Controls.Add(this.tbIndex);
            this.gbAddLineToNewsItem.Controls.Add(this.tbLine);
            this.gbAddLineToNewsItem.Controls.Add(this.label5);
            this.gbAddLineToNewsItem.Controls.Add(this.label6);
            this.gbAddLineToNewsItem.Controls.Add(this.btnAddLine);
            this.gbAddLineToNewsItem.Location = new System.Drawing.Point(25, 230);
            this.gbAddLineToNewsItem.Name = "gbAddLineToNewsItem";
            this.gbAddLineToNewsItem.Size = new System.Drawing.Size(296, 256);
            this.gbAddLineToNewsItem.TabIndex = 4;
            this.gbAddLineToNewsItem.TabStop = false;
            this.gbAddLineToNewsItem.Text = "add line to news-item";
            // 
            // btnInsertLine
            // 
            this.btnInsertLine.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInsertLine.Location = new System.Drawing.Point(21, 205);
            this.btnInsertLine.Name = "btnInsertLine";
            this.btnInsertLine.Size = new System.Drawing.Size(265, 39);
            this.btnInsertLine.TabIndex = 8;
            this.btnInsertLine.Text = "insert line into a news-item";
            this.btnInsertLine.UseVisualStyleBackColor = false;
            this.btnInsertLine.Click += new System.EventHandler(this.btnInsertLine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "id of news-item";
            // 
            // tbIdNewsitem
            // 
            this.tbIdNewsitem.Location = new System.Drawing.Point(143, 26);
            this.tbIdNewsitem.Name = "tbIdNewsitem";
            this.tbIdNewsitem.Size = new System.Drawing.Size(148, 44);
            this.tbIdNewsitem.TabIndex = 6;
            this.tbIdNewsitem.Text = "103";
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(102, 89);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(189, 44);
            this.tbIndex.TabIndex = 5;
            this.tbIndex.Text = "2";
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(102, 58);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(189, 44);
            this.tbLine.TabIndex = 4;
            this.tbLine.Text = "Willem likes flowers.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "at index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "line";
            // 
            // btnAddLine
            // 
            this.btnAddLine.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddLine.Location = new System.Drawing.Point(21, 164);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(266, 32);
            this.btnAddLine.TabIndex = 1;
            this.btnAddLine.Text = "add line to a news-item";
            this.btnAddLine.UseVisualStyleBackColor = false;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnShowInfoOfNewsitem
            // 
            this.btnShowInfoOfNewsitem.BackColor = System.Drawing.Color.Violet;
            this.btnShowInfoOfNewsitem.Location = new System.Drawing.Point(9, 91);
            this.btnShowInfoOfNewsitem.Name = "btnShowInfoOfNewsitem";
            this.btnShowInfoOfNewsitem.Size = new System.Drawing.Size(184, 32);
            this.btnShowInfoOfNewsitem.TabIndex = 10;
            this.btnShowInfoOfNewsitem.Text = "show info of news-item";
            this.btnShowInfoOfNewsitem.UseVisualStyleBackColor = false;
            this.btnShowInfoOfNewsitem.Click += new System.EventHandler(this.btnShowInfoOfNewsitem_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 37;
            this.lbInfo.Location = new System.Drawing.Point(327, 11);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(581, 189);
            this.lbInfo.TabIndex = 5;
            // 
            // gbShowInfo
            // 
            this.gbShowInfo.BackColor = System.Drawing.Color.PaleGreen;
            this.gbShowInfo.Controls.Add(this.tbxFilterAuthor);
            this.gbShowInfo.Controls.Add(this.btnShowFromAuthor);
            this.gbShowInfo.Controls.Add(this.tbId);
            this.gbShowInfo.Controls.Add(this.btnShowInfoOfNewsitem);
            this.gbShowInfo.Controls.Add(this.btnShowGeneralInfoOfAllNewsitems);
            this.gbShowInfo.Location = new System.Drawing.Point(327, 222);
            this.gbShowInfo.Name = "gbShowInfo";
            this.gbShowInfo.Size = new System.Drawing.Size(581, 255);
            this.gbShowInfo.TabIndex = 6;
            this.gbShowInfo.TabStop = false;
            this.gbShowInfo.Text = "show info";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(199, 94);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(64, 44);
            this.tbId.TabIndex = 11;
            this.tbId.Text = "103";
            // 
            // btnShowGeneralInfoOfAllNewsitems
            // 
            this.btnShowGeneralInfoOfAllNewsitems.BackColor = System.Drawing.Color.Violet;
            this.btnShowGeneralInfoOfAllNewsitems.Location = new System.Drawing.Point(9, 30);
            this.btnShowGeneralInfoOfAllNewsitems.Name = "btnShowGeneralInfoOfAllNewsitems";
            this.btnShowGeneralInfoOfAllNewsitems.Size = new System.Drawing.Size(266, 29);
            this.btnShowGeneralInfoOfAllNewsitems.TabIndex = 1;
            this.btnShowGeneralInfoOfAllNewsitems.Text = "show general  info of all news-items";
            this.btnShowGeneralInfoOfAllNewsitems.UseVisualStyleBackColor = false;
            this.btnShowGeneralInfoOfAllNewsitems.Click += new System.EventHandler(this.btnShowGeneralInfoOfAllNewsitems_Click);
            // 
            // tbxFilterAuthor
            // 
            this.tbxFilterAuthor.Location = new System.Drawing.Point(295, 160);
            this.tbxFilterAuthor.Name = "tbxFilterAuthor";
            this.tbxFilterAuthor.Size = new System.Drawing.Size(264, 44);
            this.tbxFilterAuthor.TabIndex = 15;
            this.tbxFilterAuthor.Text = "Medhat Riad";
            // 
            // btnShowFromAuthor
            // 
            this.btnShowFromAuthor.BackColor = System.Drawing.Color.Violet;
            this.btnShowFromAuthor.Location = new System.Drawing.Point(12, 160);
            this.btnShowFromAuthor.Name = "btnShowFromAuthor";
            this.btnShowFromAuthor.Size = new System.Drawing.Size(266, 29);
            this.btnShowFromAuthor.TabIndex = 14;
            this.btnShowFromAuthor.Text = "show news-items with author";
            this.btnShowFromAuthor.UseVisualStyleBackColor = false;
            this.btnShowFromAuthor.Click += new System.EventHandler(this.btnShowFromAuthor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 489);
            this.Controls.Add(this.gbShowInfo);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.gbAddLineToNewsItem);
            this.Controls.Add(this.gbAddNewsItem);
            this.Controls.Add(this.btnFillMagazineWithSomeNewsitems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddNewsItem.ResumeLayout(false);
            this.gbAddNewsItem.PerformLayout();
            this.gbAddLineToNewsItem.ResumeLayout(false);
            this.gbAddLineToNewsItem.PerformLayout();
            this.gbShowInfo.ResumeLayout(false);
            this.gbShowInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillMagazineWithSomeNewsitems;
        private System.Windows.Forms.Button btnAddNewsitem;
        private System.Windows.Forms.GroupBox gbAddNewsItem;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstLine;
        private System.Windows.Forms.GroupBox gbAddLineToNewsItem;
        private System.Windows.Forms.Button btnInsertLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdNewsitem;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.GroupBox gbShowInfo;
        private System.Windows.Forms.Button btnShowInfoOfNewsitem;
        private System.Windows.Forms.Button btnShowGeneralInfoOfAllNewsitems;
        private System.Windows.Forms.Button btnRemoveNewsItem;
        private System.Windows.Forms.ComboBox cbNewstype;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbxFilterAuthor;
        private System.Windows.Forms.Button btnShowFromAuthor;
    }
}

