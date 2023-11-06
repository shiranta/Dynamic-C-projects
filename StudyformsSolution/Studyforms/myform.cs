using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studyforms
{
    public partial class myform : Form
    {
        private Container component;
        private Label howdylabel;

        public myform()
        {
            InitializeComponent();
            InitializeComponent1();
        }
        private void InitializeComponent1()
        {
            component = new Container();
            howdylabel = new Label();

            howdylabel.Location = new Point(12, 116);
            howdylabel.Text = "Howdy partner !";
            howdylabel.Size = new Size(267, 40);
            howdylabel.AutoSize = true;
            howdylabel.Font = new Font("Microsoft Sans serif",
                                        26, System.Drawing.FontStyle.Bold);
            howdylabel.TabIndex = 0;
            howdylabel.Anchor = AnchorStyles.None;
            howdylabel.TextAlign = ContentAlignment.MiddleCenter;
            Text = "First form Srilanka";
            Controls.Add(howdylabel);

            WebSite mySite = new WebSite("gogo", "www.gogo.lk", "Eacy cash");
            
           

            //Console.WriteLine("Site name{0}", mySite);
            //Console.ReadLine();
            


        }
        private void myform_Load(object sender, EventArgs e)
        {

        }
    }
}
