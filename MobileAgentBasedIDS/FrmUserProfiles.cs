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
    public partial class FrmUserProfiles : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbMAIDS.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        
        public FrmUserProfiles()
        {
            InitializeComponent();
            cmd.Connection = cn;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;
                    string UserType = cboUserType.Text;
                    string SystemName = cboSystemName.Text;
                    string IPAddress = txtIPAddress.Text;
                    

                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblUser values('" + Username + "','" + Password + "','" + UserType + "','" + SystemName + "','" + IPAddress + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New User Profiles Successfully Saved!!!", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        MessageBox.Show("Proceed to profile processes for the user", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmProcessProfiles frmProcessProfiles = new FrmProcessProfiles(Username);
                        frmProcessProfiles.Show();
                    }

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtUsername.Text == ""))
            {
                MessageBox.Show("Please type the Username", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return isEntryFilled;
            }
            else if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Please type the Password", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return isEntryFilled;
            }
            else if ((cboUserType.Text == ""))
            {
                MessageBox.Show("Please specify the user type", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserType.Focus();
                return isEntryFilled;
            }
            else if ((cboSystemName.Text == ""))
            {
                MessageBox.Show("Please specify the system name", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSystemName.Focus();
                return isEntryFilled;
            }
            else
                return true;
        }

        private void FrmUserProfiles_Load(object sender, EventArgs e)
        {
            loadAllSystemName();
        }

        private void loadAllSystemName()
        {
            try
            {
                cboSystemName.Items.Clear();
                cn.Open();
                cmd.CommandText = "select System_Name from tblSystem";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboSystemName.Items.Add((dr["System_Name"]).ToString());
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSystemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSystemName.Text == "")
            {
                MessageBox.Show("No System name available. Please select the system name.", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSystemName.Focus();
            }
            else
            {
                setSystemIPAddress(cboSystemName.Text);
            }
        }

        private void setSystemIPAddress(string sysID)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select IP_Address from tblSystem where System_Name = '" + sysID + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtIPAddress.Text = dr["IP_Address"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
