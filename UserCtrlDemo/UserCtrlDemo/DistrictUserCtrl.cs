using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCtrlDemo
{
    public partial class DistrictUserCtrl : UserControl
    {
        public DistrictUserCtrl()
        {
            InitializeComponent();
        }

        public District SelectedDistrict
        {
            get
            {
                return (District)cmbDistrict.SelectedItem;
            }
        }

        private void DistrictUserCtrl_Load(object sender, EventArgs e)
        {
            List<District> list = new List<District>();

            list.Add(new District { DistId = 1, DistName = "Colombo" });
            list.Add(new District { DistId = 2, DistName = "Gampha" });
            list.Add(new District { DistId = 3, DistName = "Kalutara" });
            list.Add(new District { DistId = 4, DistName = "Galle" });
            list.Add(new District { DistId = 5, DistName = "Kandy" });
            list.Add(new District { DistId = 6, DistName = "Ratnapura" });
            list.Add(new District { DistId = 7, DistName = "Putalam" });

            cmbDistrict.DataSource = list;
            cmbDistrict.ValueMember = "DistId";
            cmbDistrict.DisplayMember = "DistName";





        }
    }
}
