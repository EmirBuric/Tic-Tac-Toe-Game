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
    public partial class frmXO : Form
    {
        public frmXO()
        {
            InitializeComponent();
        }

        private void frmStartScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string plyr1 = txtPlyr1.Text;
            string plyr2 = txtPlyr2.Text;
            frmTable forma = new frmTable(plyr1,plyr2);
            forma.ShowDialog();
        }

        private void btnExitXO_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(1);
        }
    }
}
