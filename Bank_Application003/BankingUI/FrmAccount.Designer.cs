
namespace BankingUI
{
    partial class FrmAccount
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblFstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtUsID = new System.Windows.Forms.TextBox();
            this.btnUservalidate = new System.Windows.Forms.Button();
            this.btnAccCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblDispAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(47, 58);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(44, 15);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // lblFstName
            // 
            this.lblFstName.AutoSize = true;
            this.lblFstName.Location = new System.Drawing.Point(453, 63);
            this.lblFstName.Name = "lblFstName";
            this.lblFstName.Size = new System.Drawing.Size(105, 15);
            this.lblFstName.TabIndex = 1;
            this.lblFstName.Text = "Display First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(628, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(104, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Display Last Name";
            // 
            // txtUsID
            // 
            this.txtUsID.Location = new System.Drawing.Point(114, 55);
            this.txtUsID.Name = "txtUsID";
            this.txtUsID.Size = new System.Drawing.Size(150, 23);
            this.txtUsID.TabIndex = 3;
            // 
            // btnUservalidate
            // 
            this.btnUservalidate.Location = new System.Drawing.Point(292, 58);
            this.btnUservalidate.Name = "btnUservalidate";
            this.btnUservalidate.Size = new System.Drawing.Size(85, 23);
            this.btnUservalidate.TabIndex = 4;
            this.btnUservalidate.Text = "User Validate";
            this.btnUservalidate.UseVisualStyleBackColor = true;
            this.btnUservalidate.Click += new System.EventHandler(this.btnUservalidate_Click);
            // 
            // btnAccCreate
            // 
            this.btnAccCreate.Location = new System.Drawing.Point(114, 115);
            this.btnAccCreate.Name = "btnAccCreate";
            this.btnAccCreate.Size = new System.Drawing.Size(130, 23);
            this.btnAccCreate.TabIndex = 5;
            this.btnAccCreate.Text = "Account Create";
            this.btnAccCreate.UseMnemonic = false;
            this.btnAccCreate.UseVisualStyleBackColor = true;
            this.btnAccCreate.Click += new System.EventHandler(this.btnAccCreate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(301, 119);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(74, 15);
            this.lblAccountNo.TabIndex = 8;
            this.lblAccountNo.Text = "Account  No";
            this.lblAccountNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDispAccount
            // 
            this.lblDispAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblDispAccount.AutoSize = true;
            this.lblDispAccount.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDispAccount.Location = new System.Drawing.Point(415, 119);
            this.lblDispAccount.Name = "lblDispAccount";
            this.lblDispAccount.Size = new System.Drawing.Size(0, 15);
            this.lblDispAccount.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(32, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 206);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(32, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 197);
            this.panel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDispAccount);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAccCreate);
            this.Controls.Add(this.btnUservalidate);
            this.Controls.Add(this.txtUsID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFstName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAccount";
            this.Text = "Account Createing";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblFstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtUsID;
        private System.Windows.Forms.Button btnUservalidate;
        private System.Windows.Forms.Button btnAccCreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblDispAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}