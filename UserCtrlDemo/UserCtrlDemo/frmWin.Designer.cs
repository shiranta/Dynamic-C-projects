using System;

namespace UserCtrlDemo
{
    partial class frmWin
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
            this.districtUserCtrl1 = new UserCtrlDemo.DistrictUserCtrl();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // districtUserCtrl1
            // 
            this.districtUserCtrl1.BackColor = System.Drawing.Color.SandyBrown;
            this.districtUserCtrl1.Location = new System.Drawing.Point(54, 31);
            this.districtUserCtrl1.Name = "districtUserCtrl1";
            this.districtUserCtrl1.Size = new System.Drawing.Size(336, 51);
            this.districtUserCtrl1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(166, 121);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(144, 53);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 295);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.districtUserCtrl1);
            this.Name = "frmWin";
            this.Text = "frmWin";
            this.Load += new System.EventHandler(this.frmWin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DistrictUserCtrl districtUserCtrl1;
        private EventHandler districtUserCtrl1_Load;
        private System.Windows.Forms.Button btnShow;
    }
}