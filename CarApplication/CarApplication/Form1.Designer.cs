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
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Location = new System.Drawing.Point(13, 13);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(35, 13);
            this.lblCarInfo.TabIndex = 0;
            this.lblCarInfo.Text = "label1";
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(13, 51);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 1;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(94, 51);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 2;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 100);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.lblCarInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Timer timer1;
    }
}

