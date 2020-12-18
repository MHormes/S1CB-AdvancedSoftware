
namespace CrazyRounding
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
            this.tbxInputNumber = new System.Windows.Forms.TextBox();
            this.rbToWhole = new System.Windows.Forms.RadioButton();
            this.rbToTenth = new System.Windows.Forms.RadioButton();
            this.rbToHundred = new System.Windows.Forms.RadioButton();
            this.btnRound = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // tbxInputNumber
            // 
            this.tbxInputNumber.Location = new System.Drawing.Point(65, 6);
            this.tbxInputNumber.Name = "tbxInputNumber";
            this.tbxInputNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxInputNumber.TabIndex = 1;
            // 
            // rbToWhole
            // 
            this.rbToWhole.AutoSize = true;
            this.rbToWhole.Location = new System.Drawing.Point(65, 32);
            this.rbToWhole.Name = "rbToWhole";
            this.rbToWhole.Size = new System.Drawing.Size(72, 17);
            this.rbToWhole.TabIndex = 2;
            this.rbToWhole.TabStop = true;
            this.rbToWhole.Text = "To Whole";
            this.rbToWhole.UseVisualStyleBackColor = true;
            // 
            // rbToTenth
            // 
            this.rbToTenth.AutoSize = true;
            this.rbToTenth.Location = new System.Drawing.Point(65, 55);
            this.rbToTenth.Name = "rbToTenth";
            this.rbToTenth.Size = new System.Drawing.Size(69, 17);
            this.rbToTenth.TabIndex = 3;
            this.rbToTenth.TabStop = true;
            this.rbToTenth.Text = "To Tenth";
            this.rbToTenth.UseVisualStyleBackColor = true;
            // 
            // rbToHundred
            // 
            this.rbToHundred.AutoSize = true;
            this.rbToHundred.Location = new System.Drawing.Point(65, 78);
            this.rbToHundred.Name = "rbToHundred";
            this.rbToHundred.Size = new System.Drawing.Size(85, 17);
            this.rbToHundred.TabIndex = 4;
            this.rbToHundred.TabStop = true;
            this.rbToHundred.Text = "To Hundreth";
            this.rbToHundred.UseVisualStyleBackColor = true;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(211, 9);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(109, 86);
            this.btnRound.TabIndex = 5;
            this.btnRound.Text = "Round 10x";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 238);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 378);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.rbToHundred);
            this.Controls.Add(this.rbToTenth);
            this.Controls.Add(this.rbToWhole);
            this.Controls.Add(this.tbxInputNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInputNumber;
        private System.Windows.Forms.RadioButton rbToWhole;
        private System.Windows.Forms.RadioButton rbToTenth;
        private System.Windows.Forms.RadioButton rbToHundred;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.ListBox listBox1;
    }
}

