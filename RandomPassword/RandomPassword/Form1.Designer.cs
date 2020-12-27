
namespace RandomPassword
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
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudAmountPasswords = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbxPasswords = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of passwords";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(147, 9);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(93, 20);
            this.nudLength.TabIndex = 2;
            this.nudLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudAmountPasswords
            // 
            this.nudAmountPasswords.Location = new System.Drawing.Point(147, 42);
            this.nudAmountPasswords.Name = "nudAmountPasswords";
            this.nudAmountPasswords.Size = new System.Drawing.Size(93, 20);
            this.nudAmountPasswords.TabIndex = 3;
            this.nudAmountPasswords.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 100);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(228, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate passwords";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Include symbols (e.g.  $, %, *)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbxPasswords
            // 
            this.lbxPasswords.FormattingEnabled = true;
            this.lbxPasswords.Location = new System.Drawing.Point(15, 144);
            this.lbxPasswords.Name = "lbxPasswords";
            this.lbxPasswords.Size = new System.Drawing.Size(225, 212);
            this.lbxPasswords.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.lbxPasswords);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.nudAmountPasswords);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudAmountPasswords;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lbxPasswords;
    }
}

