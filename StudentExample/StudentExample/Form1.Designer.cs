namespace StudentExample
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
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.tbxPCN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(120, 33);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentName.TabIndex = 0;
            // 
            // tbxPCN
            // 
            this.tbxPCN.Location = new System.Drawing.Point(120, 70);
            this.tbxPCN.Name = "tbxPCN";
            this.tbxPCN.Size = new System.Drawing.Size(100, 20);
            this.tbxPCN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "student name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "pcn";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(120, 134);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "show info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.Location = new System.Drawing.Point(261, 33);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(336, 147);
            this.lstStudent.TabIndex = 7;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(27, 200);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(162, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "search pcn";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 353);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPCN);
            this.Controls.Add(this.tbxStudentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.TextBox tbxPCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstStudent;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

