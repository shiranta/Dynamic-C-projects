using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCtrlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("District ID {0}, Name of the District {1}", districtUserCtrl1.SelectedDistrict.DistId, districtUserCtrl1.SelectedDistrict.DistName));
        }
    }
}
