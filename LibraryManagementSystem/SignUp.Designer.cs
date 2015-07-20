namespace LibraryManagementSystem
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radManager = new System.Windows.Forms.RadioButton();
            this.radReader = new System.Windows.Forms.RadioButton();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblShade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuit.Location = new System.Drawing.Point(157, 438);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(111, 41);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(18, 438);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 41);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Submit";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radManager
            // 
            this.radManager.AutoSize = true;
            this.radManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radManager.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radManager.Location = new System.Drawing.Point(154, 376);
            this.radManager.Name = "radManager";
            this.radManager.Size = new System.Drawing.Size(70, 21);
            this.radManager.TabIndex = 12;
            this.radManager.TabStop = true;
            this.radManager.Text = "Admin";
            this.radManager.UseVisualStyleBackColor = false;
            // 
            // radReader
            // 
            this.radReader.AutoSize = true;
            this.radReader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radReader.Location = new System.Drawing.Point(66, 376);
            this.radReader.Name = "radReader";
            this.radReader.Size = new System.Drawing.Size(79, 21);
            this.radReader.TabIndex = 11;
            this.radReader.TabStop = true;
            this.radReader.Text = "Reader";
            this.radReader.UseVisualStyleBackColor = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(55, 339);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(169, 16);
            this.txtPwd.TabIndex = 10;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Location = new System.Drawing.Point(56, 285);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 16);
            this.txtID.TabIndex = 9;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblShade
            // 
            this.lblShade.AutoSize = true;
            this.lblShade.BackColor = System.Drawing.Color.White;
            this.lblShade.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShade.Location = new System.Drawing.Point(-9, 364);
            this.lblShade.Name = "lblShade";
            this.lblShade.Size = new System.Drawing.Size(298, 64);
            this.lblShade.TabIndex = 15;
            this.lblShade.Text = "                  ";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 502);
            this.Controls.Add(this.lblShade);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.radManager);
            this.Controls.Add(this.radReader);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radManager;
        private System.Windows.Forms.RadioButton radReader;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblShade;
    }
}