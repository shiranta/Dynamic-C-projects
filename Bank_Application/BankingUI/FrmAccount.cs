using Bank_Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace BankingUI
{
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnUservalidate_Click(object sender, EventArgs e)
        {

            UserService us = new UserService();
            string Fullname = us.GetBankUser(uint.Parse(txtUsID.Text));
            
            
        }

        private void btnAccCreate_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService account = new AccountService();
                uint AccNo = account.CreateBankAccount(uint.Parse(txtUsID.Text));
                lblDispAccount.Text = AccNo.ToString();
                lblDispAccount.Visible = true;

                //MessageBox.Show(AccNo.ToString());
            }
            catch
                {
                MessageBox.Show("Error Occured");
                }
            finally
            { 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
