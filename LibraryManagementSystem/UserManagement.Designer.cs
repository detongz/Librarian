namespace LibraryManagementSystem
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.btuQuit = new System.Windows.Forms.Button();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radReader = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btuQuit
            // 
            this.btuQuit.FlatAppearance.BorderSize = 0;
            this.btuQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btuQuit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuQuit.Location = new System.Drawing.Point(278, 562);
            this.btuQuit.Name = "btuQuit";
            this.btuQuit.Size = new System.Drawing.Size(75, 25);
            this.btuQuit.TabIndex = 0;
            this.btuQuit.Text = "quit";
            this.btuQuit.UseVisualStyleBackColor = true;
            this.btuQuit.Click += new System.EventHandler(this.btuQuit_Click);
            // 
            // dgvReader
            // 
            this.dgvReader.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Location = new System.Drawing.Point(6, 3);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.ReadOnly = true;
            this.dgvReader.RowTemplate.Height = 23;
            this.dgvReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReader.Size = new System.Drawing.Size(320, 218);
            this.dgvReader.TabIndex = 1;
            this.dgvReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReader_CellClick_1);
            this.dgvReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReader_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // radReader
            // 
            this.radReader.AutoSize = true;
            this.radReader.Checked = true;
            this.radReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radReader.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReader.Location = new System.Drawing.Point(150, 267);
            this.radReader.Name = "radReader";
            this.radReader.Size = new System.Drawing.Size(74, 21);
            this.radReader.TabIndex = 5;
            this.radReader.TabStop = true;
            this.radReader.Text = "Reader";
            this.radReader.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdmin.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.Location = new System.Drawing.Point(221, 267);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(66, 21);
            this.radAdmin.TabIndex = 6;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(150, 244);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 17);
            this.txtID.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(187, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(97, 562);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 25);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(6, 6);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowTemplate.Height = 23;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(320, 215);
            this.dgvAdmin.TabIndex = 12;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick_1);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(16, 562);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 305);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 250);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAdmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administrator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvReader);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(332, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reader";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(149, 209);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 25);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "view";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(367, 639);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.radReader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btuQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btuQuit;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radReader;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnView;
    }
}