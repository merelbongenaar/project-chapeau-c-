using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;
using ChapeauUI;

namespace ChapeauUI
{
    public partial class FoodOrder : Form
    {
        public FoodOrder(Order order)
        {
            InitializeComponent();
            lblDisplayTableNmbr.Text = order.TableID.ToString();
        }

        //Will change the status of the order to "Preparing"
        private void btnPrepare_Click(object sender, EventArgs e)
        {

        }

        //Will change the status to "Done"
        private void btnIsPrepared_Click(object sender, EventArgs e)
        {

        }
    }
}
