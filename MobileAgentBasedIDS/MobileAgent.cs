/***
 * This Class is developed to act as the mobile agent in this application
 * Class Name: MobileAgent.cs
 * Developer: B. Programmer
 * Date: 02/01/2018
 ***/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MobileAgentBasedIDS
{
    class MobileAgent
    {
        private static OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbMAIDS.accdb;Persist Security Info=True");
        private static OleDbCommand cmd = new OleDbCommand();
        private static OleDbDataReader dr;

        //This method is use by the mobile agent to validate the current system user trying to login
        public static bool ValidateUser(string user, string pass, string sysType)
        {
            bool validate = false;
            try
            {
                cmd.Connection = cn;
                cn.Open();
                //First query is based on system name given 
                cmd.CommandText = "select Username, Password from tblUser where Username = '" + user + "' and Password = '" + pass + "' and System_Name = '" + sysType + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    validate = true;
                }
                else
                {
                    //Second query is based on IP_Address given 
                    cmd.CommandText = "select Username, Password from tblUser where Username = '" + user + "' and Password = '" + pass + "' and IP_Address = '" + sysType + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        validate = true;
                    }
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
            return validate;
        }


        public static bool ValidateSystem(string p)
        {
            bool validate = false;
            try
            {
                cmd.Connection = cn;
                cn.Open();
                //Query is to validate the system name given
                cmd.CommandText = "select System_Name from tblSystem where System_Name = '" + p + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    validate = true;
                }
                else
                {
                    //Second query is based on IP_Address given 
                    cmd.CommandText = "select System_Name from tblSystem where IP_Address = '" + p + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        validate = true;
                    }
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
            return validate; 
        }
    }
}
