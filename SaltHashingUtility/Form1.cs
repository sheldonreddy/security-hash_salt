using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;
using System.Configuration;
using SaltHashingUtility.Entities.ControlHub;
using System.IO;
using SaltHashingUtility.Log;
using SaltHashingUtility.Utility;

namespace SaltHashingUtility
{
    public partial class hashingForm : Form
    {
        #region Form
        public hashingForm()
        {
            InitializeComponent();
            Logger.Process("SaltHashUtil Initialised", System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public Hashtable AppConfig;

        private void hashingForm_Load(object sender, EventArgs e)
        {
            #region ToolTips
            System.Windows.Forms.ToolTip HashPWCopyBTNToolTip = new System.Windows.Forms.ToolTip();
            HashPWCopyBTNToolTip.SetToolTip(this.hashcopyBTN, "Copy Hashed Password");
            System.Windows.Forms.ToolTip SaltCopyBTNToolTip = new System.Windows.Forms.ToolTip();
            SaltCopyBTNToolTip.SetToolTip(this.saltcopyBTN, "Copy Salt");
            #endregion

            #region AppConfig
            AppConfig = new Hashtable((from key in System.Configuration.ConfigurationManager.AppSettings.Keys.Cast<string>()
                                       let value = System.Configuration.ConfigurationManager.AppSettings[key]
                                       select new { key, value }).ToDictionary(x => x.key, x => x.value));

            Logger.Configuration("AppConfig Imported", System.Reflection.MethodBase.GetCurrentMethod().Name);
            Logger.Configuration(string.Format("DatabaseUpdate Enabled: {0}", AppConfig["DatabaseUpdate"].ToString()), System.Reflection.MethodBase.GetCurrentMethod().Name);
            #endregion

            #region Controls
            if (!bool.Parse(AppConfig["DatabaseUpdate"].ToString()))
            {
                dbstatusLBL.Text = "Disabled in AppConfig";
                dbstatusLBL.ForeColor = Color.IndianRed;
                newuserRB.Enabled = false;
                existinguserRB.Enabled = false;
            }
            else
            {
                newuserRB.Checked = true;
            }

            adduserBTN.Enabled = false;
            adduserTB.Enabled = false;
            removeuserBTN.Enabled = false;
            dbupdatecsvBTN.Enabled = false;

            #endregion
        }

        private void existinguserRB_CheckedChanged(object sender, EventArgs e)
        {
            emailTB.Enabled = false;
            roleidTB.Enabled = false;
        }

        private void newuserRB_CheckedChanged(object sender, EventArgs e)
        {
            emailTB.Enabled = true;
            roleidTB.Enabled = true;
        }

        #endregion

        #region SINGLE TAB 

        #region Hash
        private void hashBTN_Click(object sender, EventArgs e)
        {

            HashWithSaltResult hashResultSha256 = HashSalt.HashPassword(pwordTB.Text);

            #region Hash Password
            hashpwordTB.Text = hashResultSha256.Digest;
            saltTB.Text = hashResultSha256.Salt;
            #endregion
        }

        private void hashcopyBTN_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();    
            Clipboard.SetText(hashpwordTB.Text); 
        }

        private void saltcopyBTN_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();          
            Clipboard.SetText(saltTB.Text); 
        }

        #endregion

        #endregion

        #region MULTI TAB
        public List<string> userDir = new List<string>();
        private void csvimportBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Displays an OpenFileDialog so the user can select a Cursor. 
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "CSV Files|*.csv";
                openFileDialog1.Title = "Select the TagGroup File";
                openFileDialog1.Multiselect = false;
                openFileDialog1.ValidateNames = true;
                string importUsersPath = "";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Assign the cursor in the Stream to the Form's Cursor property. 
                    //this.Cursor = new Cursor(openFileDialog1.OpenFile());
                    importUsersPath = openFileDialog1.FileName;
                    string FileName = openFileDialog1.SafeFileName;
                    // Import Tag Group from File
                    StreamReader reader = new StreamReader(File.OpenRead(importUsersPath));
                    // Import Tags into tag list
                    while (!reader.EndOfStream)
                    {
                        // Read in line by line
                        string line = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(',');
                            foreach (string v in values)
                            {
                                if (v.Length > 0 && !userDir.Contains(v))
                                {
                                    // Process Values
                                    userDir.Add(v);
                                    usersLB.Items.Add(v);
                                }
                            }
                        }
                    }

                    // Process error
                    csvupdatestatusLBL.Text = "CSV Import Complete";
                    csvupdatestatusLBL.ForeColor = Color.Green;
                    Logger.Process(string.Format("CSV {0} Import Success", importUsersPath), System.Reflection.MethodBase.GetCurrentMethod().Name);

                    adduserBTN.Enabled = true;
                    adduserTB.Enabled = true;
                    removeuserBTN.Enabled = true;
                    dbupdatecsvBTN.Enabled = true;
                }
                else
                {
                    // Process error
                    csvupdatestatusLBL.Text = "CSV Import Failed";
                    csvupdatestatusLBL.ForeColor = Color.Red;
                    Logger.Error(string.Format("CSV {0} Import Failed", importUsersPath), System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
            }
            catch(Exception ex)
            {
                Logger.Exception(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        private void adduserBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (adduserTB.Text.Length > 0 && !userDir.Contains(adduserTB.Text))
                {
                    userDir.Add(adduserTB.Text);
                    usersLB.Items.Add(adduserTB.Text);
                }
                adduserTB.Text = "";
            }
            catch(Exception ex)
            {
                Logger.Exception(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

        }

        private void removeuserBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the currently selected item in the ListBox.
                string curItem = usersLB.SelectedItem.ToString();
                if (curItem.Length > 0)
                {
                    userDir.Remove(curItem);
                    usersLB.Items.RemoveAt(usersLB.FindString(curItem));
                }
            }
            catch(Exception ex)
            {
                // Handles Empty selection   
            }
        }

        private void dbupdatecsvBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Removed for GITHUB
         
            }
            catch(Exception ex)
            {
                Logger.Exception(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            
        }
        #endregion

        

    }
}
