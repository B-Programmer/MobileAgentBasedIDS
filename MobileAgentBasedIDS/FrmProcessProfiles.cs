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
    public partial class FrmProcessProfiles : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbMAIDS.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        private string user;
        public FrmProcessProfiles(string username)
        {
            InitializeComponent();
            this.user = username;
            cmd.Connection = cn;
        }

        private void FrmProcessProfiles_Load(object sender, EventArgs e)
        {
            txtUsername.Text = this.user;
            txtUsername.Enabled = false;
        }

        private void btnCMDCreateProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled("CMD"))
                {
                    string Username = txtUsername.Text;
                    string allowAccess = "No";
                    if (radCMDYes.Checked) allowAccess = "Yes";
                    double MaxTime = Convert.ToDouble(txtCMDMaxTime.Text);
                    double MaxProcesses = Convert.ToDouble(txtCMDMaxProcesses.Text);
                    double MaxMemory = Convert.ToDouble(txtCMDMaxMemory.Text);


                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblCMD values('" + Username + "','" + allowAccess + "'," + MaxTime + "," + MaxProcesses + "," + MaxMemory + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New CMD Process Profiles Successfully Saved!!!", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                    }

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled(string pType)
        {
            bool isEntryFilled = false;
            if (pType == "CMD")
            {
                if ((txtCMDMaxTime.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Time", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCMDMaxTime.Focus();
                    return isEntryFilled;
                }
                else if ((txtCMDMaxProcesses.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Processes", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCMDMaxProcesses.Focus();
                    return isEntryFilled;
                }
                else if ((txtCMDMaxMemory.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Memory", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCMDMaxMemory.Focus();
                    return isEntryFilled;
                }
                
            }
            else if (pType == "MSWORD")
            {
                if ((txtMSWMaxTime.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Time", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSWMaxTime.Focus();
                    return isEntryFilled;
                }
                else if ((txtMSWMaxProcesses.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Processes", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSWMaxProcesses.Focus();
                    return isEntryFilled;
                }
                else if ((txtMSWMaxMemory.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Memory", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSWMaxMemory.Focus();
                    return isEntryFilled;
                }

            }
            else if (pType == "NOTEPAD")
            {
                if ((txtNPDMaxTime.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Time", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNPDMaxTime.Focus();
                    return isEntryFilled;
                }
                else if ((txtNPDMaxProcesses.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Processes", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNPDMaxProcesses.Focus();
                    return isEntryFilled;
                }
                else if ((txtNPDMaxMemory.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Memory", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNPDMaxMemory.Focus();
                    return isEntryFilled;
                }

            }
            else if (pType == "IE")
            {
                if ((txtIEMaxTime.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Time", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIEMaxTime.Focus();
                    return isEntryFilled;
                }
                else if ((txtIEMaxProcesses.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Processes", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIEMaxProcesses.Focus();
                    return isEntryFilled;
                }
                else if ((txtIEMaxMemory.Text == ""))
                {
                    MessageBox.Show("Please type the Max. Memory", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIEMaxMemory.Focus();
                    return isEntryFilled;
                }

            }
            
                return true;
        }

        private void btnMSWCreateProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled("MSWORD"))
                {
                    string Username = txtUsername.Text;
                    string allowAccess = "No";
                    if (radMSWYes.Checked) allowAccess = "Yes";
                    double MaxTime = Convert.ToDouble(txtMSWMaxTime.Text);
                    double MaxProcesses = Convert.ToDouble(txtMSWMaxProcesses.Text);
                    double MaxMemory = Convert.ToDouble(txtMSWMaxMemory.Text);


                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblMSWord values('" + Username + "','" + allowAccess + "'," + MaxTime + "," + MaxProcesses + "," + MaxMemory + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New MS Word Process Profiles Successfully Saved!!!", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                    }

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNPDCreateProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled("NOTEPAD"))
                {
                    string Username = txtUsername.Text;
                    string allowAccess = "No";
                    if (radNPDYes.Checked) allowAccess = "Yes";
                    double MaxTime = Convert.ToDouble(txtNPDMaxTime.Text);
                    double MaxProcesses = Convert.ToDouble(txtNPDMaxProcesses.Text);
                    double MaxMemory = Convert.ToDouble(txtNPDMaxMemory.Text);


                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblNotepad values('" + Username + "','" + allowAccess + "'," + MaxTime + "," + MaxProcesses + "," + MaxMemory + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Notepad Process Profiles Successfully Saved!!!", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                    }

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIECreateProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled("IE"))
                {
                    string Username = txtUsername.Text;
                    string allowAccess = "No";
                    if (radIEYes.Checked) allowAccess = "Yes";
                    double MaxTime = Convert.ToDouble(txtIEMaxTime.Text);
                    double MaxProcesses = Convert.ToDouble(txtIEMaxProcesses.Text);
                    double MaxMemory = Convert.ToDouble(txtIEMaxMemory.Text);


                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblIExplorer values('" + Username + "','" + allowAccess + "'," + MaxTime + "," + MaxProcesses + "," + MaxMemory + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Internet Explorer Process Profiles Successfully Saved!!!", "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                    }

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Mobile Agent Intrusion Detection System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
