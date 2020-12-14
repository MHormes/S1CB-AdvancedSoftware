
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUpdateCourse = new System.Windows.Forms.TextBox();
            this.tbxRemark = new System.Windows.Forms.TextBox();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.tbxRemoveCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnPassed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxGetResults
            // 
            this.lbxGetResults.FormattingEnabled = true;
            this.lbxGetResults.Location = new System.Drawing.Point(216, 12);
            this.lbxGetResults.Name = "lbxGetResults";
            this.lbxGetResults.Size = new System.Drawing.Size(182, 147);
            this.lbxGetResults.TabIndex = 0;
            // 
            // btnGetAllResults
            // 
            this.btnGetAllResults.Location = new System.Drawing.Point(216, 165);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Update course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remark:";
            // 
            // tbxUpdateCourse
            // 
            this.tbxUpdateCourse.Location = new System.Drawing.Point(99, 257);
            this.tbxUpdateCourse.Name = "tbxUpdateCourse";
            this.tbxUpdateCourse.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateCourse.TabIndex = 10;
            // 
            // tbxRemark
            // 
            this.tbxRemark.Location = new System.Drawing.Point(99, 292);
            this.tbxRemark.Multiline = true;
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.Size = new System.Drawing.Size(299, 69);
            this.tbxRemark.TabIndex = 11;
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(99, 368);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(298, 23);
            this.btnUpdateCourse.TabIndex = 12;
            this.btnUpdateCourse.Text = "Update course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // tbxRemoveCourse
            // 
            this.tbxRemoveCourse.Location = new System.Drawing.Point(98, 440);
            this.tbxRemoveCourse.Name = "tbxRemoveCourse";
            this.tbxRemoveCourse.Size = new System.Drawing.Size(100, 20);
            this.tbxRemoveCourse.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Remove course:";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(12, 466);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(186, 23);
            this.btnRemoveCourse.TabIndex = 15;
            this.btnRemoveCourse.Text = "Remove course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnPassed
            // 
            this.btnPassed.Location = new System.Drawing.Point(16, 521);
            this.btnPassed.Name = "btnPassed";
            this.btnPassed.Size = new System.Drawing.Size(382, 50);
            this.btnPassed.TabIndex = 16;
            this.btnPassed.Text = "Check if you passed";
            this.btnPassed.UseVisualStyleBackColor = true;
            this.btnPassed.Click += new System.EventHandler(this.btnPassed_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 626);
            this.Controls.Add(this.btnPassed);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.tbxRemoveCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.tbxUpdateCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUpdateCourse;
        private System.Windows.Forms.TextBox tbxRemark;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.TextBox tbxRemoveCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnPassed;
    }
}