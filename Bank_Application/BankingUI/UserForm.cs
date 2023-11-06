using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Application.Services;



namespace BankingUI
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               UserService us = new UserService();
                uint obtainUserId=us.CreateBankUser(new User() { FirstName=txtFname.Text });
                //MessageBox.Show(obtainUserId.ToString());

            }
            catch
            {
                MessageBox.Show("Error occured while saving!");
            }
            finally {
                refreshList();
            }
            
            
        }
        private void refreshList() {
            UserService us = new UserService();
            lstUser.Items.Clear();
            us.GetAllUsers().ForEach(UserID => lstUser.Items.Add(UserID));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
            this.Hide();

        }
    }
}
