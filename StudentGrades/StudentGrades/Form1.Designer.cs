
namespace StudentGrades
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
            this.tpInput = new System.Windows.Forms.TabPage();
            this.tpStats = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.lbxGrades = new System.Windows.Forms.ListBox();
            this.lblPassed = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpInput.SuspendLayout();
            this.tpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInput);
            this.tabControl1.Controls.Add(this.tpStats);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tpInput
            // 
            this.tpInput.Controls.Add(this.lbxGrades);
            this.tpInput.Controls.Add(this.btnAddGrade);
            this.tpInput.Controls.Add(this.cbGrade);
            this.tpInput.Controls.Add(this.txbName);
            this.tpInput.Controls.Add(this.label2);
            this.tpInput.Controls.Add(this.label1);
            this.tpInput.Location = new System.Drawing.Point(4, 22);
            this.tpInput.Name = "tpInput";
            this.tpInput.Padding = new System.Windows.Forms.Padding(3);
            this.tpInput.Size = new System.Drawing.Size(362, 198);
            this.tpInput.TabIndex = 0;
            this.tpInput.Text = "Input grade";
            this.tpInput.UseVisualStyleBackColor = true;
            // 
            // tpStats
            // 
            this.tpStats.Controls.Add(this.lblS);
            this.tpStats.Controls.Add(this.lblO);
            this.tpStats.Controls.Add(this.lblG);
            this.tpStats.Controls.Add(this.lblU);
            this.tpStats.Controls.Add(this.lblP);
            this.tpStats.Controls.Add(this.label3);
            this.tpStats.Controls.Add(this.lblFail);
            this.tpStats.Controls.Add(this.lblPassed);
            this.tpStats.Location = new System.Drawing.Point(4, 22);
            this.tpStats.Name = "tpStats";
            this.tpStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats.Size = new System.Drawing.Size(362, 198);
            this.tpStats.TabIndex = 1;
            this.tpStats.Text = "Statistics";
            this.tpStats.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(58, 7);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 2;
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "P",
            "U",
            "S",
            "G",
            "O"});
            this.cbGrade.Location = new System.Drawing.Point(58, 38);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(100, 21);
            this.cbGrade.TabIndex = 3;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(10, 92);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(148, 23);
            this.btnAddGrade.TabIndex = 4;
            this.btnAddGrade.Text = "Add button to the list";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // lbxGrades
            // 
            this.lbxGrades.FormattingEnabled = true;
            this.lbxGrades.Location = new System.Drawing.Point(204, 7);
            this.lbxGrades.Name = "lbxGrades";
            this.lbxGrades.Size = new System.Drawing.Size(123, 108);
            this.lbxGrades.TabIndex = 5;
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Location = new System.Drawing.Point(7, 7);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(45, 13);
            this.lblPassed.TabIndex = 0;
            this.lblPassed.Text = "Passed:";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(10, 37);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(38, 13);
            this.lblFail.TabIndex = 1;
            this.lblFail.Text = "Failed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percentage per grade:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(13, 116);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(26, 13);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "P: 0";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(55, 117);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(27, 13);
            this.lblU.TabIndex = 4;
            this.lblU.Text = "U: 0";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(145, 116);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(27, 13);
            this.lblG.TabIndex = 5;
            this.lblG.Text = "G: 0";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(188, 116);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(27, 13);
            this.lblO.TabIndex = 6;
            this.lblO.Text = "O: 0";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(100, 117);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(26, 13);
            this.lblS.TabIndex = 7;
            this.lblS.Text = "S: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 285);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpInput.ResumeLayout(false);
            this.tpInput.PerformLayout();
            this.tpStats.ResumeLayout(false);
            this.tpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInput;
        private System.Windows.Forms.TabPage tpStats;
        private System.Windows.Forms.ListBox lbxGrades;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label label3;
    }
}

