namespace Week14_MagazineApp
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
            this.btnFillMagazineWithSomeNewsItems = new System.Windows.Forms.Button();
            this.btnAddNewsitem = new System.Windows.Forms.Button();
            this.gbAddNewsItem = new System.Windows.Forms.GroupBox();
            this.cbNewstype = new System.Windows.Forms.ComboBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveNewsItem = new System.Windows.Forms.Button();
            this.gbAddLineToNewsItem = new System.Windows.Forms.GroupBox();
            this.btnEditNewsItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdNewsItem = new System.Windows.Forms.TextBox();
            this.btnShowRandomNewsItem = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.gbShowInfo = new System.Windows.Forms.GroupBox();
            this.btnShowGeneralInfoOfAllNewsItems = new System.Windows.Forms.Button();
            this.gbAddNewsItem.SuspendLayout();
            this.gbAddLineToNewsItem.SuspendLayout();
            this.gbShowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFillMagazineWithSomeNewsItems
            // 
            this.btnFillMagazineWithSomeNewsItems.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFillMagazineWithSomeNewsItems.Location = new System.Drawing.Point(22, 6);
            this.btnFillMagazineWithSomeNewsItems.Name = "btnFillMagazineWithSomeNewsItems";
            this.btnFillMagazineWithSomeNewsItems.Size = new System.Drawing.Size(299, 42);
            this.btnFillMagazineWithSomeNewsItems.TabIndex = 0;
            this.btnFillMagazineWithSomeNewsItems.Text = "fill magazine with some news-items";
            this.btnFillMagazineWithSomeNewsItems.UseVisualStyleBackColor = false;
            this.btnFillMagazineWithSomeNewsItems.Click += new System.EventHandler(this.btnFillMagazineWithSomeNewsItems_Click);
            // 
            // btnAddNewsitem
            // 
            this.btnAddNewsitem.BackColor = System.Drawing.Color.Violet;
            this.btnAddNewsitem.Location = new System.Drawing.Point(133, 97);
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
            this.cbNewstype.Location = new System.Drawing.Point(10, 97);
            this.cbNewstype.Name = "cbNewstype";
            this.cbNewstype.Size = new System.Drawing.Size(100, 28);
            this.cbNewstype.TabIndex = 8;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(87, 55);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(189, 26);
            this.tbAuthor.TabIndex = 5;
            this.tbAuthor.Text = "Anonymous";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 23);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(189, 26);
            this.tbTitle.TabIndex = 4;
            this.tbTitle.Text = "Difficult ADA Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "title";
            // 
            // btnRemoveNewsItem
            // 
            this.btnRemoveNewsItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRemoveNewsItem.Location = new System.Drawing.Point(25, 65);
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
            this.gbAddLineToNewsItem.Controls.Add(this.btnEditNewsItem);
            this.gbAddLineToNewsItem.Controls.Add(this.btnRemoveNewsItem);
            this.gbAddLineToNewsItem.Controls.Add(this.label4);
            this.gbAddLineToNewsItem.Controls.Add(this.tbIdNewsItem);
            this.gbAddLineToNewsItem.Location = new System.Drawing.Point(25, 230);
            this.gbAddLineToNewsItem.Name = "gbAddLineToNewsItem";
            this.gbAddLineToNewsItem.Size = new System.Drawing.Size(296, 154);
            this.gbAddLineToNewsItem.TabIndex = 4;
            this.gbAddLineToNewsItem.TabStop = false;
            this.gbAddLineToNewsItem.Text = "add line to news-item";
            // 
            // btnEditNewsItem
            // 
            this.btnEditNewsItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditNewsItem.Location = new System.Drawing.Point(25, 102);
            this.btnEditNewsItem.Name = "btnEditNewsItem";
            this.btnEditNewsItem.Size = new System.Drawing.Size(266, 31);
            this.btnEditNewsItem.TabIndex = 9;
            this.btnEditNewsItem.Text = "edit news-item";
            this.btnEditNewsItem.UseVisualStyleBackColor = false;
            this.btnEditNewsItem.Click += new System.EventHandler(this.btnEditNewsItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "id of news-item";
            // 
            // tbIdNewsItem
            // 
            this.tbIdNewsItem.Location = new System.Drawing.Point(143, 26);
            this.tbIdNewsItem.Name = "tbIdNewsItem";
            this.tbIdNewsItem.Size = new System.Drawing.Size(148, 26);
            this.tbIdNewsItem.TabIndex = 6;
            // 
            // btnShowRandomNewsItem
            // 
            this.btnShowRandomNewsItem.BackColor = System.Drawing.Color.Violet;
            this.btnShowRandomNewsItem.Location = new System.Drawing.Point(391, 37);
            this.btnShowRandomNewsItem.Name = "btnShowRandomNewsItem";
            this.btnShowRandomNewsItem.Size = new System.Drawing.Size(184, 29);
            this.btnShowRandomNewsItem.TabIndex = 10;
            this.btnShowRandomNewsItem.Text = "show random content";
            this.btnShowRandomNewsItem.UseVisualStyleBackColor = false;
            this.btnShowRandomNewsItem.Click += new System.EventHandler(this.btnShowRandomNewsItem_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(327, 11);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(581, 264);
            this.lbInfo.TabIndex = 5;
            // 
            // gbShowInfo
            // 
            this.gbShowInfo.BackColor = System.Drawing.Color.PaleGreen;
            this.gbShowInfo.Controls.Add(this.btnShowRandomNewsItem);
            this.gbShowInfo.Controls.Add(this.btnShowGeneralInfoOfAllNewsItems);
            this.gbShowInfo.Location = new System.Drawing.Point(327, 295);
            this.gbShowInfo.Name = "gbShowInfo";
            this.gbShowInfo.Size = new System.Drawing.Size(581, 89);
            this.gbShowInfo.TabIndex = 6;
            this.gbShowInfo.TabStop = false;
            this.gbShowInfo.Text = "show info";
            // 
            // btnShowGeneralInfoOfAllNewsItems
            // 
            this.btnShowGeneralInfoOfAllNewsItems.BackColor = System.Drawing.Color.Violet;
            this.btnShowGeneralInfoOfAllNewsItems.Location = new System.Drawing.Point(21, 37);
            this.btnShowGeneralInfoOfAllNewsItems.Name = "btnShowGeneralInfoOfAllNewsItems";
            this.btnShowGeneralInfoOfAllNewsItems.Size = new System.Drawing.Size(266, 29);
            this.btnShowGeneralInfoOfAllNewsItems.TabIndex = 1;
            this.btnShowGeneralInfoOfAllNewsItems.Text = "show general  info of all news-items";
            this.btnShowGeneralInfoOfAllNewsItems.UseVisualStyleBackColor = false;
            this.btnShowGeneralInfoOfAllNewsItems.Click += new System.EventHandler(this.btnShowGeneralInfoOfAllNewsItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 395);
            this.Controls.Add(this.gbShowInfo);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.gbAddLineToNewsItem);
            this.Controls.Add(this.gbAddNewsItem);
            this.Controls.Add(this.btnFillMagazineWithSomeNewsItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddNewsItem.ResumeLayout(false);
            this.gbAddNewsItem.PerformLayout();
            this.gbAddLineToNewsItem.ResumeLayout(false);
            this.gbAddLineToNewsItem.PerformLayout();
            this.gbShowInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillMagazineWithSomeNewsItems;
        private System.Windows.Forms.Button btnAddNewsitem;
        private System.Windows.Forms.GroupBox gbAddNewsItem;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAddLineToNewsItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdNewsItem;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.GroupBox gbShowInfo;
        private System.Windows.Forms.Button btnShowRandomNewsItem;
        private System.Windows.Forms.Button btnShowGeneralInfoOfAllNewsItems;
        private System.Windows.Forms.Button btnRemoveNewsItem;
        private System.Windows.Forms.ComboBox cbNewstype;
        private System.Windows.Forms.Button btnEditNewsItem;
    }
}

