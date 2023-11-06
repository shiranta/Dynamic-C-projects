namespace Appmaths
{
    partial class frmCal
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
            this.txtnoOne = new System.Windows.Forms.TextBox();
            this.txtNoTwo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDed = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnoOne
            // 
            this.txtnoOne.Location = new System.Drawing.Point(94, 31);
            this.txtnoOne.Name = "txtnoOne";
            this.txtnoOne.Size = new System.Drawing.Size(59, 20);
            this.txtnoOne.TabIndex = 0;
            // 
            // txtNoTwo
            // 
            this.txtNoTwo.Location = new System.Drawing.Point(94, 69);
            this.txtNoTwo.Name = "txtNoTwo";
            this.txtNoTwo.Size = new System.Drawing.Size(59, 20);
            this.txtNoTwo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncls);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btnMul);
            this.panel1.Controls.Add(this.btnDed);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(126, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDed
            // 
            this.btnDed.Location = new System.Drawing.Point(76, 12);
            this.btnDed.Name = "btnDed";
            this.btnDed.Size = new System.Drawing.Size(34, 23);
            this.btnDed.TabIndex = 1;
            this.btnDed.Text = "-";
            this.btnDed.UseVisualStyleBackColor = true;
            this.btnDed.Click += new System.EventHandler(this.btnDed_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(19, 45);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(34, 23);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(76, 45);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(34, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(19, 74);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(34, 23);
            this.btnequal.TabIndex = 4;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            // 
            // btncls
            // 
            this.btncls.Location = new System.Drawing.Point(76, 74);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(34, 23);
            this.btncls.TabIndex = 5;
            this.btncls.Text = "CLS";
            this.btncls.UseVisualStyleBackColor = true;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(188, 31);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(59, 20);
            this.txtResult.TabIndex = 3;
            // 
            // frmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNoTwo);
            this.Controls.Add(this.txtnoOne);
            this.Name = "frmCal";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnoOne;
        private System.Windows.Forms.TextBox txtNoTwo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.TextBox txtResult;
    }
}

