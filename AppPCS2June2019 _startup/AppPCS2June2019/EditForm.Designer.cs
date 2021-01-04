namespace Week14_MagazineApp
{
    partial class EditForm
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
            this.cbNewstype = new System.Windows.Forms.ComboBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateNewsItem = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbNewstype
            // 
            this.cbNewstype.FormattingEnabled = true;
            this.cbNewstype.Location = new System.Drawing.Point(5, 220);
            this.cbNewstype.Name = "cbNewstype";
            this.cbNewstype.Size = new System.Drawing.Size(100, 21);
            this.cbNewstype.TabIndex = 14;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(83, 44);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(189, 20);
            this.tbAuthor.TabIndex = 13;
            this.tbAuthor.Text = "Georgiana Manolache";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(83, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(189, 20);
            this.tbTitle.TabIndex = 12;
            this.tbTitle.Text = "Elton John back in town";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "title";
            // 
            // btnUpdateNewsItem
            // 
            this.btnUpdateNewsItem.BackColor = System.Drawing.Color.Violet;
            this.btnUpdateNewsItem.Location = new System.Drawing.Point(128, 213);
            this.btnUpdateNewsItem.Name = "btnUpdateNewsItem";
            this.btnUpdateNewsItem.Size = new System.Drawing.Size(143, 32);
            this.btnUpdateNewsItem.TabIndex = 9;
            this.btnUpdateNewsItem.Text = "update news-item";
            this.btnUpdateNewsItem.UseVisualStyleBackColor = false;
            this.btnUpdateNewsItem.Click += new System.EventHandler(this.btnUpdateNewsItem_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(5, 79);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(266, 118);
            this.richTextBoxContent.TabIndex = 15;
            this.richTextBoxContent.Text = "";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.cbNewstype);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateNewsItem);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNewstype;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateNewsItem;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
    }
}