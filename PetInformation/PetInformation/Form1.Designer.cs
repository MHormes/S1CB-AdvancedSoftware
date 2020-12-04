namespace PetInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxBYear = new System.Windows.Forms.TextBox();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birth year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pet type";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(72, 6);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 3;
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(72, 57);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(100, 20);
            this.tbxType.TabIndex = 4;
            // 
            // tbxBYear
            // 
            this.tbxBYear.AcceptsReturn = true;
            this.tbxBYear.AcceptsTab = true;
            this.tbxBYear.Location = new System.Drawing.Point(72, 32);
            this.tbxBYear.MaxLength = 4;
            this.tbxBYear.Name = "tbxBYear";
            this.tbxBYear.Size = new System.Drawing.Size(100, 20);
            this.tbxBYear.TabIndex = 5;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(15, 94);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(157, 23);
            this.btnAddPet.TabIndex = 6;
            this.btnAddPet.Text = "Add pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(335, 32);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(75, 23);
            this.btnAge.TabIndex = 7;
            this.btnAge.Text = "Show age";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(310, 6);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Give info on pet:";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(335, 61);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfo.TabIndex = 10;
            this.btnShowInfo.Text = "Show all info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(15, 151);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "SHOW ALL";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 309);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.tbxBYear);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxBYear;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListBox listBox1;
    }
}

