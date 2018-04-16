using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobileAgentBasedIDS
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateProfiles_Click(object sender, EventArgs e)
        {
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            frmUserLogin.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FrmAdminPanel frmAdminPanel = new FrmAdminPanel();
            frmAdminPanel.Show();
        }
    }
}
