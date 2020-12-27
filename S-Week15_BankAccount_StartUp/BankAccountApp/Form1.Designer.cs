namespace BankAccountApp
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
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblShowTrans = new System.Windows.Forms.Label();
            this.lbxAccounts = new System.Windows.Forms.ListBox();
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFilterName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxFilterNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSowTransactions = new System.Windows.Forms.Button();
            this.tbxNumberForLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNumberForTrans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(12, 69);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxAmount.TabIndex = 0;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(12, 95);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 23);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(12, 124);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(620, 415);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(168, 23);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show all numbers";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblShowTrans
            // 
            this.lblShowTrans.AutoSize = true;
            this.lblShowTrans.Location = new System.Drawing.Point(12, 153);
            this.lblShowTrans.Name = "lblShowTrans";
            this.lblShowTrans.Size = new System.Drawing.Size(80, 13);
            this.lblShowTrans.TabIndex = 5;
            this.lblShowTrans.Text = "Transaction log";
            // 
            // lbxAccounts
            // 
            this.lbxAccounts.FormattingEnabled = true;
            this.lbxAccounts.Location = new System.Drawing.Point(620, 12);
            this.lbxAccounts.Name = "lbxAccounts";
            this.lbxAccounts.Size = new System.Drawing.Size(168, 394);
            this.lbxAccounts.TabIndex = 6;
            // 
            // tbxNewName
            // 
            this.tbxNewName.Location = new System.Drawing.Point(505, 16);
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(100, 20);
            this.tbxNewName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account name";
            // 
            // btnMakeAccount
            // 
            this.btnMakeAccount.Location = new System.Drawing.Point(426, 42);
            this.btnMakeAccount.Name = "btnMakeAccount";
            this.btnMakeAccount.Size = new System.Drawing.Size(178, 23);
            this.btnMakeAccount.TabIndex = 9;
            this.btnMakeAccount.Text = "Make new account ";
            this.btnMakeAccount.UseVisualStyleBackColor = true;
            this.btnMakeAccount.Click += new System.EventHandler(this.btnMakeAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter list on name";
            // 
            // tbxFilterName
            // 
            this.tbxFilterName.Location = new System.Drawing.Point(426, 92);
            this.tbxFilterName.Name = "tbxFilterName";
            this.tbxFilterName.Size = new System.Drawing.Size(178, 20);
            this.tbxFilterName.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show all numbers belonging to the inputted name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "Give information for the inputted number";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxFilterNumber
            // 
            this.tbxFilterNumber.Location = new System.Drawing.Point(427, 191);
            this.tbxFilterNumber.Name = "tbxFilterNumber";
            this.tbxFilterNumber.Size = new System.Drawing.Size(178, 20);
            this.tbxFilterNumber.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Give info for number:";
            // 
            // btnSowTransactions
            // 
            this.btnSowTransactions.Location = new System.Drawing.Point(12, 415);
            this.btnSowTransactions.Name = "btnSowTransactions";
            this.btnSowTransactions.Size = new System.Drawing.Size(182, 23);
            this.btnSowTransactions.TabIndex = 16;
            this.btnSowTransactions.Text = "Show transactions for number";
            this.btnSowTransactions.UseVisualStyleBackColor = true;
            this.btnSowTransactions.Click += new System.EventHandler(this.btnSowTransactions_Click);
            // 
            // tbxNumberForLog
            // 
            this.tbxNumberForLog.Location = new System.Drawing.Point(15, 389);
            this.tbxNumberForLog.Name = "tbxNumberForLog";
            this.tbxNumberForLog.Size = new System.Drawing.Size(179, 20);
            this.tbxNumberForLog.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number for transaction";
            // 
            // tbxNumberForTrans
            // 
            this.tbxNumberForTrans.Location = new System.Drawing.Point(12, 29);
            this.tbxNumberForTrans.Name = "tbxNumberForTrans";
            this.tbxNumberForTrans.Size = new System.Drawing.Size(100, 20);
            this.tbxNumberForTrans.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNumberForTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNumberForLog);
            this.Controls.Add(this.btnSowTransactions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxFilterNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxFilterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMakeAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNewName);
            this.Controls.Add(this.lbxAccounts);
            this.Controls.Add(this.lblShowTrans);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.tbxAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblShowTrans;
        private System.Windows.Forms.ListBox lbxAccounts;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFilterName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxFilterNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSowTransactions;
        private System.Windows.Forms.TextBox tbxNumberForLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNumberForTrans;
    }
}

