namespace SaltHashingUtility
{
    partial class hashingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SingleTab = new System.Windows.Forms.TabPage();
            this.dbstatusLBL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbupdatestatusLBL = new System.Windows.Forms.Label();
            this.hashBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pwordTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roleidTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.unameTB = new System.Windows.Forms.TextBox();
            this.existinguserRB = new System.Windows.Forms.RadioButton();
            this.newuserRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saltTB = new System.Windows.Forms.TextBox();
            this.saltcopyBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hashcopyBTN = new System.Windows.Forms.Button();
            this.hashpwordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BatchTab = new System.Windows.Forms.TabPage();
            this.adduserBTN = new System.Windows.Forms.Button();
            this.adduserTB = new System.Windows.Forms.TextBox();
            this.removeuserBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.csvupdatestatusLBL = new System.Windows.Forms.Label();
            this.usersLB = new System.Windows.Forms.ListBox();
            this.dbupdatecsvBTN = new System.Windows.Forms.Button();
            this.csvimportBTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SingleTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.BatchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SingleTab);
            this.tabControl1.Controls.Add(this.BatchTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // SingleTab
            // 
            this.SingleTab.Controls.Add(this.dbstatusLBL);
            this.SingleTab.Controls.Add(this.groupBox1);
            this.SingleTab.Controls.Add(this.groupBox2);
            this.SingleTab.Location = new System.Drawing.Point(4, 22);
            this.SingleTab.Name = "SingleTab";
            this.SingleTab.Padding = new System.Windows.Forms.Padding(3);
            this.SingleTab.Size = new System.Drawing.Size(420, 294);
            this.SingleTab.TabIndex = 0;
            this.SingleTab.Text = "Single";
            this.SingleTab.UseVisualStyleBackColor = true;
            // 
            // dbstatusLBL
            // 
            this.dbstatusLBL.AutoSize = true;
            this.dbstatusLBL.Location = new System.Drawing.Point(120, 117);
            this.dbstatusLBL.Name = "dbstatusLBL";
            this.dbstatusLBL.Size = new System.Drawing.Size(0, 13);
            this.dbstatusLBL.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbupdatestatusLBL);
            this.groupBox1.Controls.Add(this.hashBTN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pwordTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.roleidTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.emailTB);
            this.groupBox1.Controls.Add(this.unameTB);
            this.groupBox1.Controls.Add(this.existinguserRB);
            this.groupBox1.Controls.Add(this.newuserRB);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 188);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dbupdatestatusLBL
            // 
            this.dbupdatestatusLBL.AutoSize = true;
            this.dbupdatestatusLBL.Location = new System.Drawing.Point(283, 13);
            this.dbupdatestatusLBL.Name = "dbupdatestatusLBL";
            this.dbupdatestatusLBL.Size = new System.Drawing.Size(0, 13);
            this.dbupdatestatusLBL.TabIndex = 1;
            // 
            // hashBTN
            // 
            this.hashBTN.Location = new System.Drawing.Point(148, 152);
            this.hashBTN.Name = "hashBTN";
            this.hashBTN.Size = new System.Drawing.Size(100, 23);
            this.hashBTN.TabIndex = 8;
            this.hashBTN.Text = "Execute Hash";
            this.hashBTN.UseVisualStyleBackColor = true;
            this.hashBTN.Click += new System.EventHandler(this.hashBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "RoleId";
            // 
            // pwordTB
            // 
            this.pwordTB.Location = new System.Drawing.Point(116, 65);
            this.pwordTB.Name = "pwordTB";
            this.pwordTB.Size = new System.Drawing.Size(172, 20);
            this.pwordTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // roleidTB
            // 
            this.roleidTB.Location = new System.Drawing.Point(116, 122);
            this.roleidTB.Name = "roleidTB";
            this.roleidTB.Size = new System.Drawing.Size(172, 20);
            this.roleidTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(116, 91);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(172, 20);
            this.emailTB.TabIndex = 5;
            // 
            // unameTB
            // 
            this.unameTB.Location = new System.Drawing.Point(116, 37);
            this.unameTB.Name = "unameTB";
            this.unameTB.Size = new System.Drawing.Size(172, 20);
            this.unameTB.TabIndex = 3;
            // 
            // existinguserRB
            // 
            this.existinguserRB.AutoSize = true;
            this.existinguserRB.Location = new System.Drawing.Point(310, 66);
            this.existinguserRB.Name = "existinguserRB";
            this.existinguserRB.Size = new System.Drawing.Size(86, 17);
            this.existinguserRB.TabIndex = 14;
            this.existinguserRB.TabStop = true;
            this.existinguserRB.Text = "Existing User";
            this.existinguserRB.UseVisualStyleBackColor = true;
            this.existinguserRB.CheckedChanged += new System.EventHandler(this.existinguserRB_CheckedChanged);
            // 
            // newuserRB
            // 
            this.newuserRB.AutoSize = true;
            this.newuserRB.Location = new System.Drawing.Point(310, 38);
            this.newuserRB.Name = "newuserRB";
            this.newuserRB.Size = new System.Drawing.Size(72, 17);
            this.newuserRB.TabIndex = 13;
            this.newuserRB.TabStop = true;
            this.newuserRB.Text = "New User";
            this.newuserRB.UseVisualStyleBackColor = true;
            this.newuserRB.CheckedChanged += new System.EventHandler(this.newuserRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saltTB);
            this.groupBox2.Controls.Add(this.saltcopyBTN);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hashcopyBTN);
            this.groupBox2.Controls.Add(this.hashpwordTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // saltTB
            // 
            this.saltTB.Location = new System.Drawing.Point(116, 57);
            this.saltTB.Name = "saltTB";
            this.saltTB.Size = new System.Drawing.Size(239, 20);
            this.saltTB.TabIndex = 16;
            // 
            // saltcopyBTN
            // 
            this.saltcopyBTN.ForeColor = System.Drawing.Color.Transparent;
            this.saltcopyBTN.Image = global::SaltHashingUtility.Properties.Resources.clipboard;
            this.saltcopyBTN.Location = new System.Drawing.Point(374, 57);
            this.saltcopyBTN.Name = "saltcopyBTN";
            this.saltcopyBTN.Size = new System.Drawing.Size(22, 20);
            this.saltcopyBTN.TabIndex = 11;
            this.saltcopyBTN.Tag = "";
            this.saltcopyBTN.UseVisualStyleBackColor = true;
            this.saltcopyBTN.Click += new System.EventHandler(this.saltcopyBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hashed Password";
            // 
            // hashcopyBTN
            // 
            this.hashcopyBTN.ForeColor = System.Drawing.Color.Transparent;
            this.hashcopyBTN.Image = global::SaltHashingUtility.Properties.Resources.clipboard;
            this.hashcopyBTN.Location = new System.Drawing.Point(374, 21);
            this.hashcopyBTN.Name = "hashcopyBTN";
            this.hashcopyBTN.Size = new System.Drawing.Size(22, 20);
            this.hashcopyBTN.TabIndex = 10;
            this.hashcopyBTN.Tag = "";
            this.hashcopyBTN.UseVisualStyleBackColor = true;
            this.hashcopyBTN.Click += new System.EventHandler(this.hashcopyBTN_Click);
            // 
            // hashpwordTB
            // 
            this.hashpwordTB.Location = new System.Drawing.Point(116, 21);
            this.hashpwordTB.Name = "hashpwordTB";
            this.hashpwordTB.Size = new System.Drawing.Size(239, 20);
            this.hashpwordTB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salt";
            // 
            // BatchTab
            // 
            this.BatchTab.Controls.Add(this.adduserBTN);
            this.BatchTab.Controls.Add(this.adduserTB);
            this.BatchTab.Controls.Add(this.removeuserBTN);
            this.BatchTab.Controls.Add(this.label7);
            this.BatchTab.Controls.Add(this.csvupdatestatusLBL);
            this.BatchTab.Controls.Add(this.usersLB);
            this.BatchTab.Controls.Add(this.dbupdatecsvBTN);
            this.BatchTab.Controls.Add(this.csvimportBTN);
            this.BatchTab.Location = new System.Drawing.Point(4, 22);
            this.BatchTab.Name = "BatchTab";
            this.BatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.BatchTab.Size = new System.Drawing.Size(420, 294);
            this.BatchTab.TabIndex = 1;
            this.BatchTab.Text = "Batch";
            this.BatchTab.UseVisualStyleBackColor = true;
            // 
            // adduserBTN
            // 
            this.adduserBTN.Location = new System.Drawing.Point(294, 193);
            this.adduserBTN.Name = "adduserBTN";
            this.adduserBTN.Size = new System.Drawing.Size(108, 23);
            this.adduserBTN.TabIndex = 8;
            this.adduserBTN.Text = "Add User";
            this.adduserBTN.UseVisualStyleBackColor = true;
            this.adduserBTN.Click += new System.EventHandler(this.adduserBTN_Click);
            // 
            // adduserTB
            // 
            this.adduserTB.Location = new System.Drawing.Point(294, 167);
            this.adduserTB.Name = "adduserTB";
            this.adduserTB.Size = new System.Drawing.Size(108, 20);
            this.adduserTB.TabIndex = 7;
            // 
            // removeuserBTN
            // 
            this.removeuserBTN.Location = new System.Drawing.Point(294, 222);
            this.removeuserBTN.Name = "removeuserBTN";
            this.removeuserBTN.Size = new System.Drawing.Size(108, 23);
            this.removeuserBTN.TabIndex = 6;
            this.removeuserBTN.Text = "Omit User";
            this.removeuserBTN.UseVisualStyleBackColor = true;
            this.removeuserBTN.Click += new System.EventHandler(this.removeuserBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Imported Users";
            // 
            // csvupdatestatusLBL
            // 
            this.csvupdatestatusLBL.AutoSize = true;
            this.csvupdatestatusLBL.Location = new System.Drawing.Point(279, 23);
            this.csvupdatestatusLBL.Name = "csvupdatestatusLBL";
            this.csvupdatestatusLBL.Size = new System.Drawing.Size(0, 13);
            this.csvupdatestatusLBL.TabIndex = 4;
            // 
            // usersLB
            // 
            this.usersLB.FormattingEnabled = true;
            this.usersLB.Location = new System.Drawing.Point(14, 75);
            this.usersLB.Name = "usersLB";
            this.usersLB.Size = new System.Drawing.Size(261, 199);
            this.usersLB.TabIndex = 3;
            // 
            // dbupdatecsvBTN
            // 
            this.dbupdatecsvBTN.Location = new System.Drawing.Point(294, 251);
            this.dbupdatecsvBTN.Name = "dbupdatecsvBTN";
            this.dbupdatecsvBTN.Size = new System.Drawing.Size(108, 23);
            this.dbupdatecsvBTN.TabIndex = 2;
            this.dbupdatecsvBTN.Text = "Update Database";
            this.dbupdatecsvBTN.UseVisualStyleBackColor = true;
            this.dbupdatecsvBTN.Click += new System.EventHandler(this.dbupdatecsvBTN_Click);
            // 
            // csvimportBTN
            // 
            this.csvimportBTN.Location = new System.Drawing.Point(14, 13);
            this.csvimportBTN.Name = "csvimportBTN";
            this.csvimportBTN.Size = new System.Drawing.Size(75, 23);
            this.csvimportBTN.TabIndex = 0;
            this.csvimportBTN.Text = "Import CSV";
            this.csvimportBTN.UseVisualStyleBackColor = true;
            this.csvimportBTN.Click += new System.EventHandler(this.csvimportBTN_Click);
            // 
            // hashingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 344);
            this.Controls.Add(this.tabControl1);
            this.Name = "hashingForm";
            this.Text = "Hashing Utility";
            this.Load += new System.EventHandler(this.hashingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.SingleTab.ResumeLayout(false);
            this.SingleTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.BatchTab.ResumeLayout(false);
            this.BatchTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SingleTab;
        private System.Windows.Forms.Button hashBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saltTB;
        private System.Windows.Forms.TextBox hashpwordTB;
        private System.Windows.Forms.TextBox pwordTB;
        private System.Windows.Forms.TextBox unameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage BatchTab;
        private System.Windows.Forms.Button saltcopyBTN;
        private System.Windows.Forms.Button hashcopyBTN;
        private System.Windows.Forms.Label dbstatusLBL;
        private System.Windows.Forms.RadioButton existinguserRB;
        private System.Windows.Forms.RadioButton newuserRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roleidTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label dbupdatestatusLBL;
        private System.Windows.Forms.Button dbupdatecsvBTN;
        private System.Windows.Forms.Button csvimportBTN;
        private System.Windows.Forms.ListBox usersLB;
        private System.Windows.Forms.Label csvupdatestatusLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button adduserBTN;
        private System.Windows.Forms.TextBox adduserTB;
        private System.Windows.Forms.Button removeuserBTN;
    }
}

