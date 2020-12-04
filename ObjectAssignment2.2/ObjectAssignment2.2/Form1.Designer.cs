namespace ObjectAssignment2._2
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
            this.tbxCourseName = new System.Windows.Forms.TextBox();
            this.tbxCourseECs = new System.Windows.Forms.TextBox();
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.btnShowCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course ECs4";
            // 
            // tbxCourseName
            // 
            this.tbxCourseName.Location = new System.Drawing.Point(122, 11);
            this.tbxCourseName.Name = "tbxCourseName";
            this.tbxCourseName.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseName.TabIndex = 2;
            // 
            // tbxCourseECs
            // 
            this.tbxCourseECs.Location = new System.Drawing.Point(122, 43);
            this.tbxCourseECs.Name = "tbxCourseECs";
            this.tbxCourseECs.Size = new System.Drawing.Size(100, 20);
            this.tbxCourseECs.TabIndex = 3;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Location = new System.Drawing.Point(16, 83);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(207, 23);
            this.btnCreateCourse.TabIndex = 4;
            this.btnCreateCourse.Text = "Create Course-object";
            this.btnCreateCourse.UseVisualStyleBackColor = true;
            this.btnCreateCourse.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // btnShowCourse
            // 
            this.btnShowCourse.Location = new System.Drawing.Point(16, 112);
            this.btnShowCourse.Name = "btnShowCourse";
            this.btnShowCourse.Size = new System.Drawing.Size(206, 23);
            this.btnShowCourse.TabIndex = 5;
            this.btnShowCourse.Text = "Show information of crouse-object";
            this.btnShowCourse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 159);
            this.Controls.Add(this.btnShowCourse);
            this.Controls.Add(this.btnCreateCourse);
            this.Controls.Add(this.tbxCourseECs);
            this.Controls.Add(this.tbxCourseName);
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
        private System.Windows.Forms.TextBox tbxCourseName;
        private System.Windows.Forms.TextBox tbxCourseECs;
        private System.Windows.Forms.Button btnCreateCourse;
        private System.Windows.Forms.Button btnShowCourse;
    }
}

