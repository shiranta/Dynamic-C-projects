using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TextBox txtBox = new TextBox();
        private Button btnAdd = new Button();
        private ListBox lstbox = new ListBox();
        private CheckBox chkbox = new CheckBox();
        private Label lblCount = new Label();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.BackColor = Color.LightCyan;
            this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(255,465);
            this.Text = "Run Times Controls";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;


            this.btnAdd.BackColor = Color.Gray;
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(90, 25);
            this.btnAdd.Size = new System.Drawing.Size(50, 25);

            this.txtBox.Text = "Text";
            txtBox.Location = new System.Drawing.Point(10, 25);
            txtBox.Size = new System.Drawing.Size(70, 20);

            this.lstbox.Items.Add("one");
            this.lstbox.Items.Add("Two");
            this.lstbox.Items.Add("Three");
            this.lstbox.Items.Add("Four");
            this.lstbox.Sorted = true;
            this.lstbox.Location = new System.Drawing.Point(10, 55);
            this.lstbox.Size = new System.Drawing.Size(50, 45);

            this.chkbox.Text = "Disabled";
            this.chkbox.Location = new System.Drawing.Point(15, 100);
            this.chkbox.Size = new System.Drawing.Size(110, 30);

            this.lblCount.Text = lstbox.Items.Count.ToString() + "  items";
            this.lblCount.Location = new System.Drawing.Point(55, 160);
            this.lblCount.Size = new System.Drawing.Size(65, 15);

            this.Controls.Add(btnAdd);
            this.Controls.Add(txtBox);
            this.Controls.Add(lstbox);
            this.Controls.Add(chkbox);
            this.Controls.Add(lblCount);












        }
    }
}
