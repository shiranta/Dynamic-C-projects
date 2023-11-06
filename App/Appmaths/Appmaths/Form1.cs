using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalCulator;

namespace Appmaths
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }
        CalCulator.Calculator cal = new CalCulator.Calculator();

        Calculator vg = new Calculator();
        



        private void btncls_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int i = cal.Add(int.Parse(txtnoOne.Text), int.Parse(txtNoTwo.Text));
            txtResult.Text = i.ToString();
        }
        private void btnDed_Click(object sender, EventArgs e)
        {
            int i = cal.Ded(int.Parse(txtnoOne.Text), int.Parse(txtNoTwo.Text));
            txtResult.Text = i.ToString();

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int i = cal.Mul(int.Parse(txtnoOne.Text), int.Parse(txtNoTwo.Text));
            txtResult.Text = i.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int i = cal.Div(int.Parse(txtnoOne.Text), int.Parse(txtNoTwo.Text));
            txtResult.Text = i.ToString();


        }

        private void frmCal_Load(object sender, EventArgs e)
        {
            

        }
    }
}
