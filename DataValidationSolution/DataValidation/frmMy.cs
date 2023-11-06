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
    public partial class frmMy : Form
    {
        public frmMy()
        {
            myKeyPressClass myKeyPressHandler = new myKeyPressClass();

            // Create a TextBox control.
            TextBox tb = new TextBox();
            this.Controls.Add(tb);
           //tb.KeyPress += new KeyPressEventHandler(myKeyPressHandler.myKeyCounter);
            tb.KeyPress += new KeyPressEventHandler(keypressed);
            InitializeComponent();
        }
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }

            
            }
        }

    public class myKeyPressClass
    {
        static long keyPressCount = 0;
        static long backspacePressed = 0;
        static long returnPressed = 0;
        static long escPressed = 0;
        private TextBox textBox1 = new TextBox();
        private void myKeyCounter(object sender, KeyPressEventArgs ex)
        {
            switch (ex.KeyChar)
            {
                // Counts the backspaces.
                case '\b':
                    backspacePressed = backspacePressed + 1;
                    break;
                // Counts the ENTER keys.
                case '\r':
                    returnPressed = returnPressed + 1;
                    break;
                // Counts the ESC keys.  
                case (char)27:
                    escPressed = escPressed + 1;
                    break;
                // Counts all other keys.
                default:
                    keyPressCount = keyPressCount + 1;
                    break;
            }

            //tb.Text =
            //    backspacePressed + " backspaces pressed\r\n" +
            //    escPressed + " escapes pressed\r\n" +
            //    returnPressed + " returns pressed\r\n" +
            //    keyPressCount + " other keys pressed\r\n";
            //ex.Handled = true;
        }
    }






}

