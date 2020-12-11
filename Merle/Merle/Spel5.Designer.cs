
namespace Merle
{
    partial class Spel5
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 155);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vraag 5:\r\n\r\nKan jij de code kraken...dan mag jij je cadeau open maken!\r\n\r\nVul de " +
    "code in en klik op de knop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.BackColor = System.Drawing.Color.Red;
            this.btnCheckCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCode.ForeColor = System.Drawing.Color.White;
            this.btnCheckCode.Location = new System.Drawing.Point(490, 605);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(368, 99);
            this.btnCheckCode.TabIndex = 8;
            this.btnCheckCode.Text = "Controleer de code";
            this.btnCheckCode.UseVisualStyleBackColor = false;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // tbxCode
            // 
            this.tbxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCode.Location = new System.Drawing.Point(305, 309);
            this.tbxCode.Multiline = true;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(733, 47);
            this.tbxCode.TabIndex = 9;
            // 
            // lblMess
            // 
            this.lblMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.ForeColor = System.Drawing.Color.White;
            this.lblMess.Location = new System.Drawing.Point(12, 436);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(1338, 36);
            this.lblMess.TabIndex = 10;
            this.lblMess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Spel5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1362, 786);
            this.Controls.Add(this.lblMess);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.label2);
            this.Name = "Spel5";
            this.Text = "Spel5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblMess;
    }
}