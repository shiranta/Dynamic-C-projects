using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDefineUserCtrl
{
    public partial class DistrictCtl : UserControl
    {
        public DistrictCtl()
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
        private void DistrictCtl_Load(object sender, EventArgs e)
        {
            List<District> lst = new List<District>();
            lst.Add(new District { DistId = 1, DistName = "Ampara" });
            lst.Add(new District { DistId = 2, DistName = "Colombo" });
            lst.Add(new District { DistId = 3, DistName = "Gampha" });
            lst.Add(new District { DistId = 4, DistName = "Putalam" });
            lst.Add(new District { DistId = 5, DistName = "Kurunegala" });

            cmbDistrict.DataSource = lst;
            cmbDistrict.ValueMember = "DistId";
            cmbDistrict.DisplayMember = "DistName";
            }
    }
}
