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

            
        }

        private void bttnLunch_Click(object sender, EventArgs e)
        {
            List<Item>
            flowPnlItems.Show();

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

            foreach (Item item in collection)
            {

            }


        }

        private void bttnDiner_Click(object sender, EventArgs e)
        {

        }

        private void bttnDrinks_Click(object sender, EventArgs e)
        {

        }

    }
}
