
namespace PhoneBook
{
    partial class PhoneBook
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
            this.Edtbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.Insbtn = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPhoneNumb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchNumb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Edtbtn
            // 
            this.Edtbtn.AutoSize = true;
            this.Edtbtn.Location = new System.Drawing.Point(342, 504);
            this.Edtbtn.Name = "Edtbtn";
            this.Edtbtn.Size = new System.Drawing.Size(75, 27);
            this.Edtbtn.TabIndex = 0;
            this.Edtbtn.Text = "Edit";
            this.Edtbtn.UseVisualStyleBackColor = true;
            //this.Edtbtn.Click += new System.EventHandler(this.Edtbtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.AutoSize = true;
            this.Delbtn.Location = new System.Drawing.Point(191, 504);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(75, 27);
            this.Delbtn.TabIndex = 1;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Insbtn
            // 
            this.Insbtn.AutoSize = true;
            this.Insbtn.Location = new System.Drawing.Point(52, 504);
            this.Insbtn.Name = "Insbtn";
            this.Insbtn.Size = new System.Drawing.Size(75, 27);
            this.Insbtn.TabIndex = 2;
            this.Insbtn.Text = "Insert";
            this.Insbtn.UseVisualStyleBackColor = true;
            this.Insbtn.Click += new System.EventHandler(this.Insbtn_Click);
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(52, 324);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(1038, 161);
            this.dataView.TabIndex = 4;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbAddr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbPhoneNumb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 227);
            this.panel1.TabIndex = 5;
            // 
            // txbAddr
            // 
            this.txbAddr.Location = new System.Drawing.Point(208, 148);
            this.txbAddr.Multiline = true;
            this.txbAddr.Name = "txbAddr";
            this.txbAddr.Size = new System.Drawing.Size(622, 62);
            this.txbAddr.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(208, 107);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(341, 22);
            this.txbEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txbPhoneNumb
            // 
            this.txbPhoneNumb.Location = new System.Drawing.Point(208, 64);
            this.txbPhoneNumb.Name = "txbPhoneNumb";
            this.txbPhoneNumb.Size = new System.Drawing.Size(341, 22);
            this.txbPhoneNumb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(208, 25);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(341, 22);
            this.txbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // SearchNumb
            // 
            this.SearchNumb.Location = new System.Drawing.Point(260, 285);
            this.SearchNumb.Name = "SearchNumb";
            this.SearchNumb.Size = new System.Drawing.Size(622, 22);
            this.SearchNumb.TabIndex = 7;
            this.SearchNumb.TextChanged += new System.EventHandler(this.SearchNumb_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.Location = new System.Drawing.Point(541, 504);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 27);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.Location = new System.Drawing.Point(715, 504);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 27);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSize = true;
            this.SearchBtn.Location = new System.Drawing.Point(52, 284);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 27);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 554);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SearchNumb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.Insbtn);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.Edtbtn);
            this.Name = "PhoneBook";
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.PhoneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edtbtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Button Insbtn;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPhoneNumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchNumb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}

