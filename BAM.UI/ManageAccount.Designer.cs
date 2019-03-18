namespace BAM.UI
{
    partial class ManageAccount
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelDepositOrWithdraw = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelAfter = new System.Windows.Forms.Label();
            this.labelCurrentAmount = new System.Windows.Forms.Label();
            this.labelAfterAmount = new System.Windows.Forms.Label();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.radioButtonDeposit = new System.Windows.Forms.RadioButton();
            this.radioButtonWithdraw = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(245, 20);
            this.labelHeader.TabIndex = 21;
            this.labelHeader.Text = "Deposit or withdraw from account";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(16, 67);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 22;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // labelDepositOrWithdraw
            // 
            this.labelDepositOrWithdraw.AutoSize = true;
            this.labelDepositOrWithdraw.Location = new System.Drawing.Point(12, 51);
            this.labelDepositOrWithdraw.Name = "labelDepositOrWithdraw";
            this.labelDepositOrWithdraw.Size = new System.Drawing.Size(43, 13);
            this.labelDepositOrWithdraw.TabIndex = 23;
            this.labelDepositOrWithdraw.Text = "Amount";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.Location = new System.Drawing.Point(12, 134);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(105, 16);
            this.labelCurrent.TabIndex = 24;
            this.labelCurrent.Text = "Current balance:";
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfter.Location = new System.Drawing.Point(12, 154);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(138, 16);
            this.labelAfter.TabIndex = 25;
            this.labelAfter.Text = "Balance after change:";
            // 
            // labelCurrentAmount
            // 
            this.labelCurrentAmount.AutoSize = true;
            this.labelCurrentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentAmount.Location = new System.Drawing.Point(165, 134);
            this.labelCurrentAmount.Name = "labelCurrentAmount";
            this.labelCurrentAmount.Size = new System.Drawing.Size(25, 16);
            this.labelCurrentAmount.TabIndex = 26;
            this.labelCurrentAmount.Text = "0 ,-";
            // 
            // labelAfterAmount
            // 
            this.labelAfterAmount.AutoSize = true;
            this.labelAfterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfterAmount.Location = new System.Drawing.Point(165, 154);
            this.labelAfterAmount.Name = "labelAfterAmount";
            this.labelAfterAmount.Size = new System.Drawing.Size(25, 16);
            this.labelAfterAmount.TabIndex = 27;
            this.labelAfterAmount.Text = "0 ,-";
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(12, 196);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(100, 23);
            this.buttonCommit.TabIndex = 28;
            this.buttonCommit.Text = "Commit change";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // radioButtonDeposit
            // 
            this.radioButtonDeposit.AutoSize = true;
            this.radioButtonDeposit.Checked = true;
            this.radioButtonDeposit.Location = new System.Drawing.Point(16, 94);
            this.radioButtonDeposit.Name = "radioButtonDeposit";
            this.radioButtonDeposit.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDeposit.TabIndex = 29;
            this.radioButtonDeposit.TabStop = true;
            this.radioButtonDeposit.Text = "Deposit";
            this.radioButtonDeposit.UseVisualStyleBackColor = true;
            this.radioButtonDeposit.CheckedChanged += new System.EventHandler(this.radioButtonDeposit_CheckedChanged);
            // 
            // radioButtonWithdraw
            // 
            this.radioButtonWithdraw.AutoSize = true;
            this.radioButtonWithdraw.Location = new System.Drawing.Point(83, 94);
            this.radioButtonWithdraw.Name = "radioButtonWithdraw";
            this.radioButtonWithdraw.Size = new System.Drawing.Size(70, 17);
            this.radioButtonWithdraw.TabIndex = 30;
            this.radioButtonWithdraw.TabStop = true;
            this.radioButtonWithdraw.Text = "Withdraw";
            this.radioButtonWithdraw.UseVisualStyleBackColor = true;
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.radioButtonWithdraw);
            this.Controls.Add(this.radioButtonDeposit);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.labelAfterAmount);
            this.Controls.Add(this.labelCurrentAmount);
            this.Controls.Add(this.labelAfter);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelDepositOrWithdraw);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelHeader);
            this.Name = "ManageAccount";
            this.Text = "Manage account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelDepositOrWithdraw;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.Label labelCurrentAmount;
        private System.Windows.Forms.Label labelAfterAmount;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.RadioButton radioButtonDeposit;
        private System.Windows.Forms.RadioButton radioButtonWithdraw;
    }
}