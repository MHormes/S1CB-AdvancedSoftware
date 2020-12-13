
namespace StudentResults2._3
{
    partial class Form2
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
            this.lbxGetResults = new System.Windows.Forms.ListBox();
            this.btnGetAllResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCourseCode = new System.Windows.Forms.TextBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.cbxGrade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbxGetResults
            // 
            this.lbxGetResults.FormattingEnabled = true;
            this.lbxGetResults.Location = new System.Drawing.Point(313, 12);
            this.lbxGetResults.Name = "lbxGetResults";
            this.lbxGetResults.Size = new System.Drawing.Size(182, 212);
            this.lbxGetResults.TabIndex = 0;
            // 
            // btnGetAllResults
            // 
            this.btnGetAllResults.Location = new System.Drawing.Point(313, 231);
            this.btnGetAllResults.Name = "btnGetAllResults";
            this.btnGetAllResults.Size = new System.Drawing.Size(182, 23);
            this.btnGetAllResults.TabIndex = 1;
            this.btnGetAllResults.Text = "Get all results";
            this.btnGetAllResults.UseVisualStyleBackColor = true;
            this.btnGetAllResults.Click += new System.EventHandler(this.btnGetAllResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grade";
            // 
            // tbxCourseCode
            // 
            this.tbxCourseCode.Location = new System.Drawing.Point(86, 12);
            this.tbxCourseCode.Name = "tbxCourseCode";
            this.tbxCourseCode.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseCode.TabIndex = 4;
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(86, 78);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(100, 23);
            this.btnAddResult.TabIndex = 6;
            this.btnAddResult.Text = "Add result";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // cbxGrade
            // 
            this.cbxGrade.FormattingEnabled = true;
            this.cbxGrade.Location = new System.Drawing.Point(86, 40);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(100, 21);
            this.cbxGrade.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 626);
            this.Controls.Add(this.cbxGrade);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.tbxCourseCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetAllResults);
            this.Controls.Add(this.lbxGetResults);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxGetResults;
        private System.Windows.Forms.Button btnGetAllResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCourseCode;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.ComboBox cbxGrade;
    }
}