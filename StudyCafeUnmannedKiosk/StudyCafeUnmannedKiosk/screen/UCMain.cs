using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCafeUnmannedKiosk.screen
{
    public partial class UCMain : UserControl
    {
        UCDetailedSeating uCDetailedSeating = new UCDetailedSeating();
        public UCMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateNow.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void btnDetailedSeating_Click(object sender, EventArgs e)
        {
            ucDetailedSeating1.BringToFront();
        }
    }
}
