using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataValidation vali = new DataValidation();


        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.charonly(e);

            vali.UpperCaseLetter(sender, e);

            //if ((e.KeyChar >= 'a') && (e.KeyChar <= 'z'))
            //{
            //    int iPos = txtName.SelectionStart;
            //    int iLen = txtName.SelectionLength;
            //    txtName.Text = txtName.Text.Remove(iPos, iLen).Insert(iPos, Char.ToUpper(e.KeyChar).ToString());
            //    txtName.SelectionStart = iPos + 1;
            //    e.Handled = true;
            //}
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.digitonly(e);
            vali.UpperCaseLetter(sender, e);



        }


     //   private void txtName_KeyDown(object sender, KeyEventArgs e)
     //     {

     //       e.Handled = true;
     //       TextBox tb = sender as TextBox;
     //       //tb.Text = tb.Text.ToUpper() + e.KeyChar.ToString().ToUpper();

     //       txtName.Text.ToUpper();


     //   }

        //private void txtName_TextChanged(object sender, EventArgs e)
        //{
        //    txtName.CharacterCasing = CharacterCasing.Upper;
        //    //txtName.Text= txtName.Text.ToUpper();
        //    //txtName.SelectionStart = txtName.Text.Length+ 1;
        //}
    }
}
