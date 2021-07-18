
namespace PhoneDictionary
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
            this.panel1 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.svbtn = new System.Windows.Forms.Button();
            this.edtbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.insbtn = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(103, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 17);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "Full Name";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(309, 33);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(256, 22);
            this.FullName.TabIndex = 1;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(309, 72);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(303, 22);
            this.PhoneNumber.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(103, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 17);
            this.panel2.TabIndex = 2;
            this.panel2.Text = "Phone Number";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(309, 116);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(347, 22);
            this.Email.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Location = new System.Drawing.Point(103, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 17);
            this.panel3.TabIndex = 4;
            this.panel3.Text = "Email";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(309, 160);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(587, 64);
            this.Address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(309, 248);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(587, 22);
            this.Search.TabIndex = 9;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(97, 247);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(75, 23);
            this.srchbtn.TabIndex = 10;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(821, 558);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // svbtn
            // 
            this.svbtn.Location = new System.Drawing.Point(640, 558);
            this.svbtn.Name = "svbtn";
            this.svbtn.Size = new System.Drawing.Size(75, 23);
            this.svbtn.TabIndex = 12;
            this.svbtn.Text = "Save";
            this.svbtn.UseVisualStyleBackColor = true;
            this.svbtn.Click += new System.EventHandler(this.svbtn_Click);
            // 
            // edtbtn
            // 
            this.edtbtn.Location = new System.Drawing.Point(440, 558);
            this.edtbtn.Name = "edtbtn";
            this.edtbtn.Size = new System.Drawing.Size(75, 23);
            this.edtbtn.TabIndex = 13;
            this.edtbtn.Text = "Edit";
            this.edtbtn.UseVisualStyleBackColor = true;
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(262, 558);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 14;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // insbtn
            // 
            this.insbtn.Location = new System.Drawing.Point(97, 558);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(75, 23);
            this.insbtn.TabIndex = 15;
            this.insbtn.Text = "Insert";
            this.insbtn.UseVisualStyleBackColor = true;
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(97, 298);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(799, 239);
            this.dataView.TabIndex = 16;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 593);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.insbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.edtbtn);
            this.Controls.Add(this.svbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label panel1;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label panel2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label panel3;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button svbtn;
        private System.Windows.Forms.Button edtbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button insbtn;
        private System.Windows.Forms.DataGridView dataView;
    }
}

