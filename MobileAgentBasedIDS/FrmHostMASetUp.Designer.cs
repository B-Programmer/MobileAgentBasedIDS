namespace MobileAgentBasedIDS
{
    partial class FrmHostMASetUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateShortestDelay = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNodes = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtNoOfNodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateMA = new System.Windows.Forms.Button();
            this.txtNoOfMobileAgents = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(21, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 603);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateShortestDelay);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstNodes);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtNoOfNodes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Settings";
            // 
            // btnGenerateShortestDelay
            // 
            this.btnGenerateShortestDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateShortestDelay.Location = new System.Drawing.Point(657, 229);
            this.btnGenerateShortestDelay.Name = "btnGenerateShortestDelay";
            this.btnGenerateShortestDelay.Size = new System.Drawing.Size(165, 58);
            this.btnGenerateShortestDelay.TabIndex = 9;
            this.btnGenerateShortestDelay.Text = "&Generate Shortest Delay";
            this.btnGenerateShortestDelay.UseVisualStyleBackColor = true;
            this.btnGenerateShortestDelay.Click += new System.EventHandler(this.btnGenerateShortestDelay_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(210, 238);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(425, 122);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(207, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "List of Nodes(Hosts), Neighbors with their shortest delay from node to node:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(210, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 122);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(230, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "List of Nodes(Hosts), Neighbors with Weights:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of Nodes(Hosts):";
            // 
            // lstNodes
            // 
            this.lstNodes.FormattingEnabled = true;
            this.lstNodes.Location = new System.Drawing.Point(29, 77);
            this.lstNodes.Name = "lstNodes";
            this.lstNodes.Size = new System.Drawing.Size(126, 121);
            this.lstNodes.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(495, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 24);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNoOfNodes
            // 
            this.txtNoOfNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNoOfNodes.Location = new System.Drawing.Point(312, 16);
            this.txtNoOfNodes.Name = "txtNoOfNodes";
            this.txtNoOfNodes.Size = new System.Drawing.Size(165, 26);
            this.txtNoOfNodes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of Nodes(Hosts):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCreateMA);
            this.groupBox2.Controls.Add(this.txtNoOfMobileAgents);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(20, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mobile Agent Settings";
            // 
            // btnCreateMA
            // 
            this.btnCreateMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMA.Location = new System.Drawing.Point(540, 18);
            this.btnCreateMA.Name = "btnCreateMA";
            this.btnCreateMA.Size = new System.Drawing.Size(109, 24);
            this.btnCreateMA.TabIndex = 5;
            this.btnCreateMA.Text = "&Create M. A.";
            this.btnCreateMA.UseVisualStyleBackColor = true;
            this.btnCreateMA.Click += new System.EventHandler(this.btnCreateMA_Click);
            // 
            // txtNoOfMobileAgents
            // 
            this.txtNoOfMobileAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNoOfMobileAgents.Location = new System.Drawing.Point(357, 16);
            this.txtNoOfMobileAgents.Name = "txtNoOfMobileAgents";
            this.txtNoOfMobileAgents.Size = new System.Drawing.Size(165, 26);
            this.txtNoOfMobileAgents.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter the number of Mobile Agents:";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(146, 87);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(425, 122);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label6.Location = new System.Drawing.Point(143, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "List of Mobile Agents, Server Nodes(Hosts), Client Nodes:";
            // 
            // FrmHostMASetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 619);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHostMASetUp";
            this.Text = "Host and Mobile Agent Settings Form";
            this.Load += new System.EventHandler(this.FrmHostMASetUp_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNoOfNodes;
        private System.Windows.Forms.ListBox lstNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateShortestDelay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateMA;
        private System.Windows.Forms.TextBox txtNoOfMobileAgents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label6;
    }
}

