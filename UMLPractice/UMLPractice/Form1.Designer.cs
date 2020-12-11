
namespace UMLPractice
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
            this.tbxMemberName = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnGroupInfo = new System.Windows.Forms.Button();
            this.tbxStudentNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "member name";
            // 
            // tbxMemberName
            // 
            this.tbxMemberName.Location = new System.Drawing.Point(101, 13);
            this.tbxMemberName.Name = "tbxMemberName";
            this.tbxMemberName.Size = new System.Drawing.Size(100, 20);
            this.tbxMemberName.TabIndex = 1;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(16, 101);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(177, 23);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnGroupInfo
            // 
            this.btnGroupInfo.Location = new System.Drawing.Point(16, 130);
            this.btnGroupInfo.Name = "btnGroupInfo";
            this.btnGroupInfo.Size = new System.Drawing.Size(177, 23);
            this.btnGroupInfo.TabIndex = 3;
            this.btnGroupInfo.Text = "Show info on group";
            this.btnGroupInfo.UseVisualStyleBackColor = true;
            this.btnGroupInfo.Click += new System.EventHandler(this.btnGroupInfo_Click);
            // 
            // tbxStudentNumber
            // 
            this.tbxStudentNumber.Location = new System.Drawing.Point(101, 47);
            this.tbxStudentNumber.Name = "tbxStudentNumber";
            this.tbxStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 284);
            this.Controls.Add(this.tbxStudentNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGroupInfo);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.tbxMemberName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMemberName;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnGroupInfo;
        private System.Windows.Forms.TextBox tbxStudentNumber;
        private System.Windows.Forms.Label label2;
    }
}

