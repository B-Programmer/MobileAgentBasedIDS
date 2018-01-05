using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MobileAgentBasedIDS
{
    public partial class FrmUserLogin : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbMAIDS.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;


        public FrmUserLogin()
        {
            InitializeComponent();
            cmd.Connection = cn;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtSystemName.Text != "") && (txtUsername.Text != "") && (txtPassword.Text != ""))
            {
                if (MobileAgent.ValidateSystem(txtSystemName.Text))
                {
                    if (MobileAgent.ValidateUser(txtUsername.Text, txtPassword.Text, txtSystemName.Text))
                    {
                        MessageBox.Show("Username and password validated successfully!!!", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmUserDesktop frmUserDesktop = new FrmUserDesktop(txtUsername.Text, txtSystemName.Text);
                        frmUserDesktop.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Intrusion detected!!!, Incorrect username or password trying to log on to the system", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Intrusion detected!!!, Incorrect username or password trying to log on to the system", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username or password cannot be emptied, please type username or password including the system/IP", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
