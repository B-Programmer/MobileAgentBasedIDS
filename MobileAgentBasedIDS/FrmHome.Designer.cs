namespace MobileAgentBasedIDS
{
    partial class FrmHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCreateProfiles = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(708, 160);
            this.label2.TabIndex = 29;
            this.label2.Text = "DEVELOPMENT OF A MOBILE AGENT-BASED INTRUSION DETECTION SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuit);
            this.panel2.Controls.Add(this.btnCreateProfiles);
            this.panel2.Controls.Add(this.btnServer);
            this.panel2.Location = new System.Drawing.Point(337, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 282);
            this.panel2.TabIndex = 30;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuit.Location = new System.Drawing.Point(5, 195);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(186, 87);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCreateProfiles
            // 
            this.btnCreateProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProfiles.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateProfiles.Location = new System.Drawing.Point(5, 102);
            this.btnCreateProfiles.Name = "btnCreateProfiles";
            this.btnCreateProfiles.Size = new System.Drawing.Size(186, 87);
            this.btnCreateProfiles.TabIndex = 16;
            this.btnCreateProfiles.Text = "USERS";
            this.btnCreateProfiles.UseVisualStyleBackColor = false;
            this.btnCreateProfiles.Click += new System.EventHandler(this.btnCreateProfiles_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnServer.Location = new System.Drawing.Point(4, 9);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(186, 87);
            this.btnServer.TabIndex = 14;
            this.btnServer.Text = "ADMIN";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(880, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCreateProfiles;
        private System.Windows.Forms.Button btnServer;
    }
}