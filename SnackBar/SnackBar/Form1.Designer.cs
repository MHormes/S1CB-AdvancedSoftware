
namespace SnackBar
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
            this.label3 = new System.Windows.Forms.Label();
            this.nudFrikandel = new System.Windows.Forms.NumericUpDown();
            this.nudKroket = new System.Windows.Forms.NumericUpDown();
            this.nudMexicano = new System.Windows.Forms.NumericUpDown();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnShowRevenue = new System.Windows.Forms.Button();
            this.rbFrikandel = new System.Windows.Forms.RadioButton();
            this.rbKroket = new System.Windows.Forms.RadioButton();
            this.rbMexicano = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNewStock = new System.Windows.Forms.NumericUpDown();
            this.nudNewPrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowAllInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrikandel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKroket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMexicano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frikandel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kroket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mexicano";
            // 
            // nudFrikandel
            // 
            this.nudFrikandel.Location = new System.Drawing.Point(16, 30);
            this.nudFrikandel.Name = "nudFrikandel";
            this.nudFrikandel.Size = new System.Drawing.Size(66, 20);
            this.nudFrikandel.TabIndex = 3;
            // 
            // nudKroket
            // 
            this.nudKroket.Location = new System.Drawing.Point(115, 30);
            this.nudKroket.Name = "nudKroket";
            this.nudKroket.Size = new System.Drawing.Size(66, 20);
            this.nudKroket.TabIndex = 4;
            // 
            // nudMexicano
            // 
            this.nudMexicano.Location = new System.Drawing.Point(214, 30);
            this.nudMexicano.Name = "nudMexicano";
            this.nudMexicano.Size = new System.Drawing.Size(66, 20);
            this.nudMexicano.TabIndex = 5;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(16, 56);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(264, 23);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnShowRevenue
            // 
            this.btnShowRevenue.Location = new System.Drawing.Point(347, 161);
            this.btnShowRevenue.Name = "btnShowRevenue";
            this.btnShowRevenue.Size = new System.Drawing.Size(208, 23);
            this.btnShowRevenue.TabIndex = 7;
            this.btnShowRevenue.Text = "show revenue";
            this.btnShowRevenue.UseVisualStyleBackColor = true;
            this.btnShowRevenue.Click += new System.EventHandler(this.btnShowRevenue_Click);
            // 
            // rbFrikandel
            // 
            this.rbFrikandel.AutoSize = true;
            this.rbFrikandel.Location = new System.Drawing.Point(344, 29);
            this.rbFrikandel.Name = "rbFrikandel";
            this.rbFrikandel.Size = new System.Drawing.Size(68, 17);
            this.rbFrikandel.TabIndex = 8;
            this.rbFrikandel.TabStop = true;
            this.rbFrikandel.Text = "Frikandel";
            this.rbFrikandel.UseVisualStyleBackColor = true;
            // 
            // rbKroket
            // 
            this.rbKroket.AutoSize = true;
            this.rbKroket.Location = new System.Drawing.Point(422, 29);
            this.rbKroket.Name = "rbKroket";
            this.rbKroket.Size = new System.Drawing.Size(56, 17);
            this.rbKroket.TabIndex = 9;
            this.rbKroket.TabStop = true;
            this.rbKroket.Text = "Kroket";
            this.rbKroket.UseVisualStyleBackColor = true;
            // 
            // rbMexicano
            // 
            this.rbMexicano.AutoSize = true;
            this.rbMexicano.Location = new System.Drawing.Point(484, 29);
            this.rbMexicano.Name = "rbMexicano";
            this.rbMexicano.Size = new System.Drawing.Size(71, 17);
            this.rbMexicano.TabIndex = 10;
            this.rbMexicano.TabStop = true;
            this.rbMexicano.Text = "Mexicano";
            this.rbMexicano.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change stock or price of:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "New price";
            // 
            // nudNewStock
            // 
            this.nudNewStock.Location = new System.Drawing.Point(347, 77);
            this.nudNewStock.Name = "nudNewStock";
            this.nudNewStock.Size = new System.Drawing.Size(68, 20);
            this.nudNewStock.TabIndex = 14;
            // 
            // nudNewPrice
            // 
            this.nudNewPrice.Location = new System.Drawing.Point(484, 77);
            this.nudNewPrice.Name = "nudNewPrice";
            this.nudNewPrice.Size = new System.Drawing.Size(71, 20);
            this.nudNewPrice.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(347, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Change stock and price";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowAllInfo
            // 
            this.btnShowAllInfo.Location = new System.Drawing.Point(347, 132);
            this.btnShowAllInfo.Name = "btnShowAllInfo";
            this.btnShowAllInfo.Size = new System.Drawing.Size(208, 23);
            this.btnShowAllInfo.TabIndex = 17;
            this.btnShowAllInfo.Text = "Show all stock";
            this.btnShowAllInfo.UseVisualStyleBackColor = true;
            this.btnShowAllInfo.Click += new System.EventHandler(this.btnShowAllInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 189);
            this.Controls.Add(this.btnShowAllInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudNewPrice);
            this.Controls.Add(this.nudNewStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbMexicano);
            this.Controls.Add(this.rbKroket);
            this.Controls.Add(this.rbFrikandel);
            this.Controls.Add(this.btnShowRevenue);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.nudMexicano);
            this.Controls.Add(this.nudKroket);
            this.Controls.Add(this.nudFrikandel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFrikandel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKroket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMexicano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFrikandel;
        private System.Windows.Forms.NumericUpDown nudKroket;
        private System.Windows.Forms.NumericUpDown nudMexicano;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnShowRevenue;
        private System.Windows.Forms.RadioButton rbFrikandel;
        private System.Windows.Forms.RadioButton rbKroket;
        private System.Windows.Forms.RadioButton rbMexicano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNewStock;
        private System.Windows.Forms.NumericUpDown nudNewPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowAllInfo;
    }
}

