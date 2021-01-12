namespace ZebraFarm
{
    partial class DetailsForm
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
            this.btnUpdateAndClose = new System.Windows.Forms.Button();
            this.rbnZebraGenderUnknown = new System.Windows.Forms.RadioButton();
            this.rbnZebraGenderStallion = new System.Windows.Forms.RadioButton();
            this.rbnZebraGenderMare = new System.Windows.Forms.RadioButton();
            this.tbxZebraName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateAndClose
            // 
            this.btnUpdateAndClose.Location = new System.Drawing.Point(12, 120);
            this.btnUpdateAndClose.Name = "btnUpdateAndClose";
            this.btnUpdateAndClose.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateAndClose.TabIndex = 15;
            this.btnUpdateAndClose.Text = "Update zebra and close form";
            this.btnUpdateAndClose.UseVisualStyleBackColor = true;
            this.btnUpdateAndClose.Click += new System.EventHandler(this.btnUpdateAndClose_Click);
            // 
            // rbnZebraGenderUnknown
            // 
            this.rbnZebraGenderUnknown.AutoSize = true;
            this.rbnZebraGenderUnknown.Location = new System.Drawing.Point(56, 92);
            this.rbnZebraGenderUnknown.Name = "rbnZebraGenderUnknown";
            this.rbnZebraGenderUnknown.Size = new System.Drawing.Size(71, 17);
            this.rbnZebraGenderUnknown.TabIndex = 14;
            this.rbnZebraGenderUnknown.TabStop = true;
            this.rbnZebraGenderUnknown.Text = "Unknown";
            this.rbnZebraGenderUnknown.UseVisualStyleBackColor = true;
            // 
            // rbnZebraGenderStallion
            // 
            this.rbnZebraGenderStallion.AutoSize = true;
            this.rbnZebraGenderStallion.Location = new System.Drawing.Point(56, 69);
            this.rbnZebraGenderStallion.Name = "rbnZebraGenderStallion";
            this.rbnZebraGenderStallion.Size = new System.Drawing.Size(59, 17);
            this.rbnZebraGenderStallion.TabIndex = 13;
            this.rbnZebraGenderStallion.TabStop = true;
            this.rbnZebraGenderStallion.Text = "Stallion";
            this.rbnZebraGenderStallion.UseVisualStyleBackColor = true;
            // 
            // rbnZebraGenderMare
            // 
            this.rbnZebraGenderMare.AutoSize = true;
            this.rbnZebraGenderMare.Location = new System.Drawing.Point(56, 46);
            this.rbnZebraGenderMare.Name = "rbnZebraGenderMare";
            this.rbnZebraGenderMare.Size = new System.Drawing.Size(49, 17);
            this.rbnZebraGenderMare.TabIndex = 12;
            this.rbnZebraGenderMare.TabStop = true;
            this.rbnZebraGenderMare.Text = "Mare";
            this.rbnZebraGenderMare.UseVisualStyleBackColor = true;
            // 
            // tbxZebraName
            // 
            this.tbxZebraName.Location = new System.Drawing.Point(56, 12);
            this.tbxZebraName.Name = "tbxZebraName";
            this.tbxZebraName.Size = new System.Drawing.Size(144, 20);
            this.tbxZebraName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 153);
            this.Controls.Add(this.btnUpdateAndClose);
            this.Controls.Add(this.rbnZebraGenderUnknown);
            this.Controls.Add(this.rbnZebraGenderStallion);
            this.Controls.Add(this.rbnZebraGenderMare);
            this.Controls.Add(this.tbxZebraName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateAndClose;
        private System.Windows.Forms.RadioButton rbnZebraGenderUnknown;
        private System.Windows.Forms.RadioButton rbnZebraGenderStallion;
        private System.Windows.Forms.RadioButton rbnZebraGenderMare;
        private System.Windows.Forms.TextBox tbxZebraName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}