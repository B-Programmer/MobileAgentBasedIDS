namespace MobileAgentBasedIDS
{
    partial class FrmProcessProfiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCMD = new System.Windows.Forms.TabPage();
            this.radCMDNo = new System.Windows.Forms.RadioButton();
            this.radCMDYes = new System.Windows.Forms.RadioButton();
            this.txtCMDMaxMemory = new System.Windows.Forms.TextBox();
            this.btnCMDCreateProfiles = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMDMaxProcesses = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMDMaxTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMSWord = new System.Windows.Forms.TabPage();
            this.btnMSWCreateProfiles = new System.Windows.Forms.Button();
            this.radMSWNo = new System.Windows.Forms.RadioButton();
            this.radMSWYes = new System.Windows.Forms.RadioButton();
            this.txtMSWMaxMemory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSWMaxProcesses = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMSWMaxTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabNotepad = new System.Windows.Forms.TabPage();
            this.btnNPDCreateProfiles = new System.Windows.Forms.Button();
            this.radNPDNo = new System.Windows.Forms.RadioButton();
            this.radNPDYes = new System.Windows.Forms.RadioButton();
            this.txtNPDMaxMemory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNPDMaxProcesses = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNPDMaxTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabIExplorer = new System.Windows.Forms.TabPage();
            this.radIENo = new System.Windows.Forms.RadioButton();
            this.radIEYes = new System.Windows.Forms.RadioButton();
            this.txtIEMaxMemory = new System.Windows.Forms.TextBox();
            this.btnIECreateProfiles = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIEMaxProcesses = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIEMaxTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCMD.SuspendLayout();
            this.tabMSWord.SuspendLayout();
            this.tabNotepad.SuspendLayout();
            this.tabIExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Process Profiles";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 392);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCMD);
            this.tabControl1.Controls.Add(this.tabMSWord);
            this.tabControl1.Controls.Add(this.tabNotepad);
            this.tabControl1.Controls.Add(this.tabIExplorer);
            this.tabControl1.Location = new System.Drawing.Point(20, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 286);
            this.tabControl1.TabIndex = 11;
            // 
            // tabCMD
            // 
            this.tabCMD.Controls.Add(this.radCMDNo);
            this.tabCMD.Controls.Add(this.radCMDYes);
            this.tabCMD.Controls.Add(this.txtCMDMaxMemory);
            this.tabCMD.Controls.Add(this.btnCMDCreateProfiles);
            this.tabCMD.Controls.Add(this.label6);
            this.tabCMD.Controls.Add(this.txtCMDMaxProcesses);
            this.tabCMD.Controls.Add(this.label5);
            this.tabCMD.Controls.Add(this.txtCMDMaxTime);
            this.tabCMD.Controls.Add(this.label4);
            this.tabCMD.Controls.Add(this.label3);
            this.tabCMD.Location = new System.Drawing.Point(4, 22);
            this.tabCMD.Name = "tabCMD";
            this.tabCMD.Padding = new System.Windows.Forms.Padding(3);
            this.tabCMD.Size = new System.Drawing.Size(808, 260);
            this.tabCMD.TabIndex = 0;
            this.tabCMD.Text = "CMD";
            this.tabCMD.UseVisualStyleBackColor = true;
            // 
            // radCMDNo
            // 
            this.radCMDNo.AutoSize = true;
            this.radCMDNo.Location = new System.Drawing.Point(364, 42);
            this.radCMDNo.Name = "radCMDNo";
            this.radCMDNo.Size = new System.Drawing.Size(39, 17);
            this.radCMDNo.TabIndex = 12;
            this.radCMDNo.TabStop = true;
            this.radCMDNo.Text = "No";
            this.radCMDNo.UseVisualStyleBackColor = true;
            // 
            // radCMDYes
            // 
            this.radCMDYes.AutoSize = true;
            this.radCMDYes.Location = new System.Drawing.Point(227, 41);
            this.radCMDYes.Name = "radCMDYes";
            this.radCMDYes.Size = new System.Drawing.Size(43, 17);
            this.radCMDYes.TabIndex = 11;
            this.radCMDYes.TabStop = true;
            this.radCMDYes.Text = "Yes";
            this.radCMDYes.UseVisualStyleBackColor = true;
            // 
            // txtCMDMaxMemory
            // 
            this.txtCMDMaxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMDMaxMemory.Location = new System.Drawing.Point(227, 166);
            this.txtCMDMaxMemory.Name = "txtCMDMaxMemory";
            this.txtCMDMaxMemory.Size = new System.Drawing.Size(289, 26);
            this.txtCMDMaxMemory.TabIndex = 7;
            // 
            // btnCMDCreateProfiles
            // 
            this.btnCMDCreateProfiles.Location = new System.Drawing.Point(597, 213);
            this.btnCMDCreateProfiles.Name = "btnCMDCreateProfiles";
            this.btnCMDCreateProfiles.Size = new System.Drawing.Size(191, 41);
            this.btnCMDCreateProfiles.TabIndex = 10;
            this.btnCMDCreateProfiles.Text = "Create Profiles";
            this.btnCMDCreateProfiles.UseVisualStyleBackColor = true;
            this.btnCMDCreateProfiles.Click += new System.EventHandler(this.btnCMDCreateProfiles_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Max. Memory:";
            // 
            // txtCMDMaxProcesses
            // 
            this.txtCMDMaxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMDMaxProcesses.Location = new System.Drawing.Point(227, 121);
            this.txtCMDMaxProcesses.Name = "txtCMDMaxProcesses";
            this.txtCMDMaxProcesses.Size = new System.Drawing.Size(289, 26);
            this.txtCMDMaxProcesses.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max. Processes:";
            // 
            // txtCMDMaxTime
            // 
            this.txtCMDMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMDMaxTime.Location = new System.Drawing.Point(227, 80);
            this.txtCMDMaxTime.Name = "txtCMDMaxTime";
            this.txtCMDMaxTime.Size = new System.Drawing.Size(289, 26);
            this.txtCMDMaxTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max. Time:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Allow Access:";
            // 
            // tabMSWord
            // 
            this.tabMSWord.Controls.Add(this.btnMSWCreateProfiles);
            this.tabMSWord.Controls.Add(this.radMSWNo);
            this.tabMSWord.Controls.Add(this.radMSWYes);
            this.tabMSWord.Controls.Add(this.txtMSWMaxMemory);
            this.tabMSWord.Controls.Add(this.label7);
            this.tabMSWord.Controls.Add(this.txtMSWMaxProcesses);
            this.tabMSWord.Controls.Add(this.label8);
            this.tabMSWord.Controls.Add(this.txtMSWMaxTime);
            this.tabMSWord.Controls.Add(this.label9);
            this.tabMSWord.Controls.Add(this.label10);
            this.tabMSWord.Location = new System.Drawing.Point(4, 22);
            this.tabMSWord.Name = "tabMSWord";
            this.tabMSWord.Padding = new System.Windows.Forms.Padding(3);
            this.tabMSWord.Size = new System.Drawing.Size(808, 260);
            this.tabMSWord.TabIndex = 1;
            this.tabMSWord.Text = "MS Word";
            this.tabMSWord.UseVisualStyleBackColor = true;
            // 
            // btnMSWCreateProfiles
            // 
            this.btnMSWCreateProfiles.Location = new System.Drawing.Point(591, 203);
            this.btnMSWCreateProfiles.Name = "btnMSWCreateProfiles";
            this.btnMSWCreateProfiles.Size = new System.Drawing.Size(191, 41);
            this.btnMSWCreateProfiles.TabIndex = 22;
            this.btnMSWCreateProfiles.Text = "Create Profiles";
            this.btnMSWCreateProfiles.UseVisualStyleBackColor = true;
            this.btnMSWCreateProfiles.Click += new System.EventHandler(this.btnMSWCreateProfiles_Click);
            // 
            // radMSWNo
            // 
            this.radMSWNo.AutoSize = true;
            this.radMSWNo.Location = new System.Drawing.Point(372, 49);
            this.radMSWNo.Name = "radMSWNo";
            this.radMSWNo.Size = new System.Drawing.Size(39, 17);
            this.radMSWNo.TabIndex = 21;
            this.radMSWNo.TabStop = true;
            this.radMSWNo.Text = "No";
            this.radMSWNo.UseVisualStyleBackColor = true;
            // 
            // radMSWYes
            // 
            this.radMSWYes.AutoSize = true;
            this.radMSWYes.Location = new System.Drawing.Point(235, 48);
            this.radMSWYes.Name = "radMSWYes";
            this.radMSWYes.Size = new System.Drawing.Size(43, 17);
            this.radMSWYes.TabIndex = 20;
            this.radMSWYes.TabStop = true;
            this.radMSWYes.Text = "Yes";
            this.radMSWYes.UseVisualStyleBackColor = true;
            // 
            // txtMSWMaxMemory
            // 
            this.txtMSWMaxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSWMaxMemory.Location = new System.Drawing.Point(235, 173);
            this.txtMSWMaxMemory.Name = "txtMSWMaxMemory";
            this.txtMSWMaxMemory.Size = new System.Drawing.Size(289, 26);
            this.txtMSWMaxMemory.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max. Memory:";
            // 
            // txtMSWMaxProcesses
            // 
            this.txtMSWMaxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSWMaxProcesses.Location = new System.Drawing.Point(235, 128);
            this.txtMSWMaxProcesses.Name = "txtMSWMaxProcesses";
            this.txtMSWMaxProcesses.Size = new System.Drawing.Size(289, 26);
            this.txtMSWMaxProcesses.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max. Processes:";
            // 
            // txtMSWMaxTime
            // 
            this.txtMSWMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSWMaxTime.Location = new System.Drawing.Point(235, 87);
            this.txtMSWMaxTime.Name = "txtMSWMaxTime";
            this.txtMSWMaxTime.Size = new System.Drawing.Size(289, 26);
            this.txtMSWMaxTime.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Max. Time:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Allow Access:";
            // 
            // tabNotepad
            // 
            this.tabNotepad.Controls.Add(this.btnNPDCreateProfiles);
            this.tabNotepad.Controls.Add(this.radNPDNo);
            this.tabNotepad.Controls.Add(this.radNPDYes);
            this.tabNotepad.Controls.Add(this.txtNPDMaxMemory);
            this.tabNotepad.Controls.Add(this.label11);
            this.tabNotepad.Controls.Add(this.txtNPDMaxProcesses);
            this.tabNotepad.Controls.Add(this.label12);
            this.tabNotepad.Controls.Add(this.txtNPDMaxTime);
            this.tabNotepad.Controls.Add(this.label13);
            this.tabNotepad.Controls.Add(this.label14);
            this.tabNotepad.Location = new System.Drawing.Point(4, 22);
            this.tabNotepad.Name = "tabNotepad";
            this.tabNotepad.Size = new System.Drawing.Size(808, 260);
            this.tabNotepad.TabIndex = 2;
            this.tabNotepad.Text = "Notepad";
            this.tabNotepad.UseVisualStyleBackColor = true;
            // 
            // btnNPDCreateProfiles
            // 
            this.btnNPDCreateProfiles.Location = new System.Drawing.Point(595, 199);
            this.btnNPDCreateProfiles.Name = "btnNPDCreateProfiles";
            this.btnNPDCreateProfiles.Size = new System.Drawing.Size(191, 41);
            this.btnNPDCreateProfiles.TabIndex = 22;
            this.btnNPDCreateProfiles.Text = "Create Profiles";
            this.btnNPDCreateProfiles.UseVisualStyleBackColor = true;
            this.btnNPDCreateProfiles.Click += new System.EventHandler(this.btnNPDCreateProfiles_Click);
            // 
            // radNPDNo
            // 
            this.radNPDNo.AutoSize = true;
            this.radNPDNo.Location = new System.Drawing.Point(377, 43);
            this.radNPDNo.Name = "radNPDNo";
            this.radNPDNo.Size = new System.Drawing.Size(39, 17);
            this.radNPDNo.TabIndex = 21;
            this.radNPDNo.TabStop = true;
            this.radNPDNo.Text = "No";
            this.radNPDNo.UseVisualStyleBackColor = true;
            // 
            // radNPDYes
            // 
            this.radNPDYes.AutoSize = true;
            this.radNPDYes.Location = new System.Drawing.Point(240, 42);
            this.radNPDYes.Name = "radNPDYes";
            this.radNPDYes.Size = new System.Drawing.Size(43, 17);
            this.radNPDYes.TabIndex = 20;
            this.radNPDYes.TabStop = true;
            this.radNPDYes.Text = "Yes";
            this.radNPDYes.UseVisualStyleBackColor = true;
            // 
            // txtNPDMaxMemory
            // 
            this.txtNPDMaxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPDMaxMemory.Location = new System.Drawing.Point(240, 167);
            this.txtNPDMaxMemory.Name = "txtNPDMaxMemory";
            this.txtNPDMaxMemory.Size = new System.Drawing.Size(289, 26);
            this.txtNPDMaxMemory.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Max. Memory:";
            // 
            // txtNPDMaxProcesses
            // 
            this.txtNPDMaxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPDMaxProcesses.Location = new System.Drawing.Point(240, 122);
            this.txtNPDMaxProcesses.Name = "txtNPDMaxProcesses";
            this.txtNPDMaxProcesses.Size = new System.Drawing.Size(289, 26);
            this.txtNPDMaxProcesses.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Max. Processes:";
            // 
            // txtNPDMaxTime
            // 
            this.txtNPDMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPDMaxTime.Location = new System.Drawing.Point(240, 81);
            this.txtNPDMaxTime.Name = "txtNPDMaxTime";
            this.txtNPDMaxTime.Size = new System.Drawing.Size(289, 26);
            this.txtNPDMaxTime.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Max. Time:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Allow Access:";
            // 
            // tabIExplorer
            // 
            this.tabIExplorer.Controls.Add(this.radIENo);
            this.tabIExplorer.Controls.Add(this.radIEYes);
            this.tabIExplorer.Controls.Add(this.txtIEMaxMemory);
            this.tabIExplorer.Controls.Add(this.btnIECreateProfiles);
            this.tabIExplorer.Controls.Add(this.label15);
            this.tabIExplorer.Controls.Add(this.txtIEMaxProcesses);
            this.tabIExplorer.Controls.Add(this.label16);
            this.tabIExplorer.Controls.Add(this.txtIEMaxTime);
            this.tabIExplorer.Controls.Add(this.label17);
            this.tabIExplorer.Controls.Add(this.label18);
            this.tabIExplorer.Location = new System.Drawing.Point(4, 22);
            this.tabIExplorer.Name = "tabIExplorer";
            this.tabIExplorer.Size = new System.Drawing.Size(808, 260);
            this.tabIExplorer.TabIndex = 3;
            this.tabIExplorer.Text = "Internet Explorer";
            this.tabIExplorer.UseVisualStyleBackColor = true;
            // 
            // radIENo
            // 
            this.radIENo.AutoSize = true;
            this.radIENo.Location = new System.Drawing.Point(367, 39);
            this.radIENo.Name = "radIENo";
            this.radIENo.Size = new System.Drawing.Size(39, 17);
            this.radIENo.TabIndex = 22;
            this.radIENo.TabStop = true;
            this.radIENo.Text = "No";
            this.radIENo.UseVisualStyleBackColor = true;
            // 
            // radIEYes
            // 
            this.radIEYes.AutoSize = true;
            this.radIEYes.Location = new System.Drawing.Point(230, 38);
            this.radIEYes.Name = "radIEYes";
            this.radIEYes.Size = new System.Drawing.Size(43, 17);
            this.radIEYes.TabIndex = 21;
            this.radIEYes.TabStop = true;
            this.radIEYes.Text = "Yes";
            this.radIEYes.UseVisualStyleBackColor = true;
            // 
            // txtIEMaxMemory
            // 
            this.txtIEMaxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIEMaxMemory.Location = new System.Drawing.Point(230, 163);
            this.txtIEMaxMemory.Name = "txtIEMaxMemory";
            this.txtIEMaxMemory.Size = new System.Drawing.Size(289, 26);
            this.txtIEMaxMemory.TabIndex = 19;
            // 
            // btnIECreateProfiles
            // 
            this.btnIECreateProfiles.Location = new System.Drawing.Point(600, 210);
            this.btnIECreateProfiles.Name = "btnIECreateProfiles";
            this.btnIECreateProfiles.Size = new System.Drawing.Size(191, 41);
            this.btnIECreateProfiles.TabIndex = 20;
            this.btnIECreateProfiles.Text = "Create Profiles";
            this.btnIECreateProfiles.UseVisualStyleBackColor = true;
            this.btnIECreateProfiles.Click += new System.EventHandler(this.btnIECreateProfiles_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Max. Memory:";
            // 
            // txtIEMaxProcesses
            // 
            this.txtIEMaxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIEMaxProcesses.Location = new System.Drawing.Point(230, 118);
            this.txtIEMaxProcesses.Name = "txtIEMaxProcesses";
            this.txtIEMaxProcesses.Size = new System.Drawing.Size(289, 26);
            this.txtIEMaxProcesses.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Max. Processes:";
            // 
            // txtIEMaxTime
            // 
            this.txtIEMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIEMaxTime.Location = new System.Drawing.Point(230, 77);
            this.txtIEMaxTime.Name = "txtIEMaxTime";
            this.txtIEMaxTime.Size = new System.Drawing.Size(289, 26);
            this.txtIEMaxTime.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Max. Time:";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Allow Access:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(216, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // FrmProcessProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProcessProfiles";
            this.Text = "Process Profiles";
            this.Load += new System.EventHandler(this.FrmProcessProfiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCMD.ResumeLayout(false);
            this.tabCMD.PerformLayout();
            this.tabMSWord.ResumeLayout(false);
            this.tabMSWord.PerformLayout();
            this.tabNotepad.ResumeLayout(false);
            this.tabNotepad.PerformLayout();
            this.tabIExplorer.ResumeLayout(false);
            this.tabIExplorer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCMDCreateProfiles;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCMD;
        private System.Windows.Forms.TextBox txtCMDMaxMemory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMDMaxProcesses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCMDMaxTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabMSWord;
        private System.Windows.Forms.TabPage tabNotepad;
        private System.Windows.Forms.RadioButton radCMDNo;
        private System.Windows.Forms.RadioButton radCMDYes;
        private System.Windows.Forms.Button btnMSWCreateProfiles;
        private System.Windows.Forms.RadioButton radMSWNo;
        private System.Windows.Forms.RadioButton radMSWYes;
        private System.Windows.Forms.TextBox txtMSWMaxMemory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSWMaxProcesses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMSWMaxTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNPDCreateProfiles;
        private System.Windows.Forms.RadioButton radNPDNo;
        private System.Windows.Forms.RadioButton radNPDYes;
        private System.Windows.Forms.TextBox txtNPDMaxMemory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNPDMaxProcesses;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNPDMaxTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabIExplorer;
        private System.Windows.Forms.RadioButton radIENo;
        private System.Windows.Forms.RadioButton radIEYes;
        private System.Windows.Forms.TextBox txtIEMaxMemory;
        private System.Windows.Forms.Button btnIECreateProfiles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIEMaxProcesses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIEMaxTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}