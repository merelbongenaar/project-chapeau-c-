using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class Ordering : Form
    {
        public Ordering(Table table) //???
        {
            InitializeComponent();

            flowPnlcategories.Show();
        }

        private void flowPnlLunchMainItems_Paint(object sender, PaintEventArgs e)
        {
            //for each menuItem in lunch
            //foreach (var item in collection)
            //{
            //    Button testbutton = new Button();
            //    testbutton.Text = "button1";
            //    testbutton.Location = new Point(70, 70);
            //    testbutton.Size = new Size(100, 100);
            //    testbutton.Visible = true;
            //    testbutton.BringToFront();
            //    this.Controls.Add(testbutton);
            //}
        }

        private void bttnLunch_Click(object sender, EventArgs e)
        {
            //show panel 
            flowPnlLunchMainItems.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
