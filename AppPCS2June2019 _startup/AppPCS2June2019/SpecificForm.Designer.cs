
namespace AppPCS2June2019
{
    partial class SpecificForm
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
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lbxAllLines = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Location = new System.Drawing.Point(13, 13);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(35, 13);
            this.lblGeneralInfo.TabIndex = 0;
            this.lblGeneralInfo.Text = "label1";
            // 
            // lbxAllLines
            // 
            this.lbxAllLines.FormattingEnabled = true;
            this.lbxAllLines.Location = new System.Drawing.Point(12, 42);
            this.lbxAllLines.Name = "lbxAllLines";
            this.lbxAllLines.Size = new System.Drawing.Size(495, 238);
            this.lbxAllLines.TabIndex = 1;
            // 
            // SpecificForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 301);
            this.Controls.Add(this.lbxAllLines);
            this.Controls.Add(this.lblGeneralInfo);
            this.Name = "SpecificForm";
            this.Text = "SpecificForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.ListBox lbxAllLines;
    }
}