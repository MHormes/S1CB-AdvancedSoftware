namespace CarApplication
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblBMW = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblVolvo = new System.Windows.Forms.Label();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 92);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblBMW);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 66);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BMW";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblBMW
            // 
            this.lblBMW.AutoSize = true;
            this.lblBMW.Location = new System.Drawing.Point(3, 3);
            this.lblBMW.Name = "lblBMW";
            this.lblBMW.Size = new System.Drawing.Size(35, 13);
            this.lblBMW.TabIndex = 3;
            this.lblBMW.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblVolvo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Volvo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVolvo
            // 
            this.lblVolvo.AutoSize = true;
            this.lblVolvo.Location = new System.Drawing.Point(3, 3);
            this.lblVolvo.Name = "lblVolvo";
            this.lblVolvo.Size = new System.Drawing.Size(35, 13);
            this.lblVolvo.TabIndex = 6;
            this.lblVolvo.Text = "label1";
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(123, 110);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 5;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(16, 110);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 4;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 166);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Label lblBMW;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblVolvo;
    }
}

