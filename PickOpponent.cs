using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmXO
{
    public partial class frmPickOpponent : Form
    {
        public frmPickOpponent()
        {
            InitializeComponent();
        }

        private void btnVsPlyr_Click(object sender, EventArgs e)
        {
            frmXO forma = new frmXO();
            forma.ShowDialog();
        }

        private void btVsComp_Click(object sender, EventArgs e)
        {
            frmTest Frmtest= new frmTest();
            Frmtest.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
