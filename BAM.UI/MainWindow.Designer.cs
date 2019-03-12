namespace BAM.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelCustomerInformation = new System.Windows.Forms.Label();
            this.labelCustomerInfo = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(452, 23);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 29);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Create new customer";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(438, 415);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(60, 29);
            this.buttonDeposit.TabIndex = 9;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(511, 415);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(60, 29);
            this.buttonWithdraw.TabIndex = 10;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 2);
            this.label1.TabIndex = 12;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(12, 141);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(258, 303);
            this.listBoxCustomers.TabIndex = 13;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 111);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 20);
            this.textBoxSearch.TabIndex = 14;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(8, 88);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(134, 20);
            this.labelSearch.TabIndex = 15;
            this.labelSearch.Text = "Search customer:";
            // 
            // labelCustomerInformation
            // 
            this.labelCustomerInformation.AutoSize = true;
            this.labelCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerInformation.Location = new System.Drawing.Point(308, 118);
            this.labelCustomerInformation.Name = "labelCustomerInformation";
            this.labelCustomerInformation.Size = new System.Drawing.Size(165, 20);
            this.labelCustomerInformation.TabIndex = 16;
            this.labelCustomerInformation.Text = "Customer information:";
            // 
            // labelCustomerInfo
            // 
            this.labelCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCustomerInfo.Location = new System.Drawing.Point(312, 141);
            this.labelCustomerInfo.Name = "labelCustomerInfo";
            this.labelCustomerInfo.Size = new System.Drawing.Size(260, 260);
            this.labelCustomerInfo.TabIndex = 17;
            this.labelCustomerInfo.Text = "Select a customer...";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(312, 415);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(50, 29);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(375, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 29);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelCustomerInfo);
            this.Controls.Add(this.labelCustomerInformation);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Bank Account Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelCustomerInformation;
        private System.Windows.Forms.Label labelCustomerInfo;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}

