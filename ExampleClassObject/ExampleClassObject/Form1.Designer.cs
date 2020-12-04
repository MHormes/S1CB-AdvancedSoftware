namespace ExampleClassObject
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.lblSavingBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbChecking = new System.Windows.Forms.RadioButton();
            this.rdbSaving = new System.Windows.Forms.RadioButton();
            this.lblBalanceCheck = new System.Windows.Forms.Label();
            this.lblBalanceSave = new System.Windows.Forms.Label();
            this.btnGetInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(10, 153);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(130, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount to deduct/deposit";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(146, 150);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxAmount.TabIndex = 7;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(93, 176);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(12, 176);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.Location = new System.Drawing.Point(13, 13);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(138, 13);
            this.lblCheckingBalance.TabIndex = 10;
            this.lblCheckingBalance.Text = "Checking account balance:";
            // 
            // lblSavingBalance
            // 
            this.lblSavingBalance.AutoSize = true;
            this.lblSavingBalance.Location = new System.Drawing.Point(13, 35);
            this.lblSavingBalance.Name = "lblSavingBalance";
            this.lblSavingBalance.Size = new System.Drawing.Size(131, 13);
            this.lblSavingBalance.TabIndex = 11;
            this.lblSavingBalance.Text = "Savings account balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select the account below";
            // 
            // rdbChecking
            // 
            this.rdbChecking.AutoSize = true;
            this.rdbChecking.Location = new System.Drawing.Point(17, 97);
            this.rdbChecking.Name = "rdbChecking";
            this.rdbChecking.Size = new System.Drawing.Size(112, 17);
            this.rdbChecking.TabIndex = 13;
            this.rdbChecking.TabStop = true;
            this.rdbChecking.Text = "Checking account";
            this.rdbChecking.UseVisualStyleBackColor = true;
            // 
            // rdbSaving
            // 
            this.rdbSaving.AutoSize = true;
            this.rdbSaving.Location = new System.Drawing.Point(17, 120);
            this.rdbSaving.Name = "rdbSaving";
            this.rdbSaving.Size = new System.Drawing.Size(105, 17);
            this.rdbSaving.TabIndex = 14;
            this.rdbSaving.TabStop = true;
            this.rdbSaving.Text = "Savings account";
            this.rdbSaving.UseVisualStyleBackColor = true;
            // 
            // lblBalanceCheck
            // 
            this.lblBalanceCheck.AutoSize = true;
            this.lblBalanceCheck.Location = new System.Drawing.Point(150, 13);
            this.lblBalanceCheck.Name = "lblBalanceCheck";
            this.lblBalanceCheck.Size = new System.Drawing.Size(13, 13);
            this.lblBalanceCheck.TabIndex = 15;
            this.lblBalanceCheck.Text = "0";
            // 
            // lblBalanceSave
            // 
            this.lblBalanceSave.AutoSize = true;
            this.lblBalanceSave.Location = new System.Drawing.Point(150, 35);
            this.lblBalanceSave.Name = "lblBalanceSave";
            this.lblBalanceSave.Size = new System.Drawing.Size(13, 13);
            this.lblBalanceSave.TabIndex = 16;
            this.lblBalanceSave.Text = "0";
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(12, 227);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 17;
            this.btnGetInfo.Text = "Get all info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 276);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.lblBalanceSave);
            this.Controls.Add(this.lblBalanceCheck);
            this.Controls.Add(this.rdbSaving);
            this.Controls.Add(this.rdbChecking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSavingBalance);
            this.Controls.Add(this.lblCheckingBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Label lblSavingBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbChecking;
        private System.Windows.Forms.RadioButton rdbSaving;
        private System.Windows.Forms.Label lblBalanceCheck;
        private System.Windows.Forms.Label lblBalanceSave;
        private System.Windows.Forms.Button btnGetInfo;
    }
}

