
namespace GameCharacter
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
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.btnDealDmgChar1 = new System.Windows.Forms.Button();
            this.tbxDmgChar1 = new System.Windows.Forms.TextBox();
            this.tbxDmgChar2 = new System.Windows.Forms.TextBox();
            this.btnDealDmgChar2 = new System.Windows.Forms.Button();
            this.lblHealthgc1 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Location = new System.Drawing.Point(13, 13);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(79, 13);
            this.lblHealthStatus.TabIndex = 0;
            this.lblHealthStatus.Text = "Current health: ";
            // 
            // btnDealDmgChar1
            // 
            this.btnDealDmgChar1.Location = new System.Drawing.Point(12, 74);
            this.btnDealDmgChar1.Name = "btnDealDmgChar1";
            this.btnDealDmgChar1.Size = new System.Drawing.Size(112, 23);
            this.btnDealDmgChar1.TabIndex = 1;
            this.btnDealDmgChar1.Text = "Deal damage";
            this.btnDealDmgChar1.UseVisualStyleBackColor = true;
            this.btnDealDmgChar1.Click += new System.EventHandler(this.btnDealDmg_Click);
            // 
            // tbxDmgChar1
            // 
            this.tbxDmgChar1.Location = new System.Drawing.Point(12, 48);
            this.tbxDmgChar1.Name = "tbxDmgChar1";
            this.tbxDmgChar1.Size = new System.Drawing.Size(112, 20);
            this.tbxDmgChar1.TabIndex = 2;
            // 
            // tbxDmgChar2
            // 
            this.tbxDmgChar2.Location = new System.Drawing.Point(16, 179);
            this.tbxDmgChar2.Name = "tbxDmgChar2";
            this.tbxDmgChar2.Size = new System.Drawing.Size(112, 20);
            this.tbxDmgChar2.TabIndex = 5;
            // 
            // btnDealDmgChar2
            // 
            this.btnDealDmgChar2.Location = new System.Drawing.Point(16, 205);
            this.btnDealDmgChar2.Name = "btnDealDmgChar2";
            this.btnDealDmgChar2.Size = new System.Drawing.Size(112, 23);
            this.btnDealDmgChar2.TabIndex = 4;
            this.btnDealDmgChar2.Text = "Deal damage";
            this.btnDealDmgChar2.UseVisualStyleBackColor = true;
            this.btnDealDmgChar2.Click += new System.EventHandler(this.btnDealDmgChar2_Click);
            // 
            // lblHealthgc1
            // 
            this.lblHealthgc1.AutoSize = true;
            this.lblHealthgc1.Location = new System.Drawing.Point(17, 144);
            this.lblHealthgc1.Name = "lblHealthgc1";
            this.lblHealthgc1.Size = new System.Drawing.Size(79, 13);
            this.lblHealthgc1.TabIndex = 3;
            this.lblHealthgc1.Text = "Current health: ";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(212, 13);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(175, 27);
            this.btnCompare.TabIndex = 6;
            this.btnCompare.Text = "Compare health of both";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tbxDmgChar2);
            this.Controls.Add(this.btnDealDmgChar2);
            this.Controls.Add(this.lblHealthgc1);
            this.Controls.Add(this.tbxDmgChar1);
            this.Controls.Add(this.btnDealDmgChar1);
            this.Controls.Add(this.lblHealthStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Button btnDealDmgChar1;
        private System.Windows.Forms.TextBox tbxDmgChar1;
        private System.Windows.Forms.TextBox tbxDmgChar2;
        private System.Windows.Forms.Button btnDealDmgChar2;
        private System.Windows.Forms.Label lblHealthgc1;
        private System.Windows.Forms.Button btnCompare;
    }
}

