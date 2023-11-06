using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchItem
{
    public partial class Form1 : Form
    {
        List<String> originalList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            LoadListBox();
        }

        private void LoadListBox()
        {
            
            
            lstBox.Items.Add("Srilal" + " " + "25" + " " + "Male");
            originalList.Add("Srilal" + " " + "25" + " " + "Male");

            lstBox.Items.Add("Anne" + " " + "23" + " " + "FeMale");
            originalList.Add("Anne" + " " + "23" + " " + "FeMale");

            lstBox.Items.Add("Shirantha" + " " + "24" + " " + "Male");
            originalList.Add("Shirantha" + " " + "24" + " " + "Male");


            lstBox.Items.Add("Chandani" + " " + "25" + " " + "FeMale");
            originalList.Add("Chandani" + " " + "25" + " " + "FeMale");

            lstBox.Items.Add("Duma" + " " + "5" + " " + "MaleFemale");
            originalList.Add("Duma" + " " + "5" + " " + "MaleFemale");

            

            
           // MessageBox.Show(originalList.Count.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            lstBox.Items.Clear();

            //List<string> schlist = new List<string>();

            foreach (string item in originalList)
            {

                if (item.Contains(txtbox.Text))
                {
                    lstBox.Items.Add(item);
                }
            }

        }
    }
}
