namespace LibraryManagementSystem
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.lblSearchWay = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPressDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnALL = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.ofdViewPic = new System.Windows.Forms.OpenFileDialog();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(61, 248);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 36);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(245, 341);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 25);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(118, 343);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(121, 20);
            this.txtKeyWord.TabIndex = 11;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "书名",
            "作者",
            "出版社"});
            this.cmbSearch.Location = new System.Drawing.Point(9, 342);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(103, 22);
            this.cmbSearch.TabIndex = 10;
            this.cmbSearch.Text = "书名";
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKeyWord.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKeyWord.Location = new System.Drawing.Point(115, 313);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(81, 19);
            this.lblKeyWord.TabIndex = 9;
            this.lblKeyWord.Text = "Keywords";
            // 
            // lblSearchWay
            // 
            this.lblSearchWay.AutoSize = true;
            this.lblSearchWay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchWay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchWay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchWay.Location = new System.Drawing.Point(6, 314);
            this.lblSearchWay.Name = "lblSearchWay";
            this.lblSearchWay.Size = new System.Drawing.Size(99, 19);
            this.lblSearchWay.TabIndex = 8;
            this.lblSearchWay.Text = "Query mode";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(494, 250);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(186, 196);
            this.txtContent.TabIndex = 40;
            // 
            // pbCover
            // 
            this.pbCover.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCover.Location = new System.Drawing.Point(347, 250);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(141, 196);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 38;
            this.pbCover.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(410, 512);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(126, 17);
            this.txtPrice.TabIndex = 36;
            // 
            // txtPressDate
            // 
            this.txtPressDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPressDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPressDate.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPressDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPressDate.Location = new System.Drawing.Point(594, 545);
            this.txtPressDate.Name = "txtPressDate";
            this.txtPressDate.ReadOnly = true;
            this.txtPressDate.Size = new System.Drawing.Size(95, 17);
            this.txtPressDate.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date:";
            // 
            // txtPress
            // 
            this.txtPress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPress.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPress.Location = new System.Drawing.Point(594, 512);
            this.txtPress.Name = "txtPress";
            this.txtPress.ReadOnly = true;
            this.txtPress.Size = new System.Drawing.Size(95, 17);
            this.txtPress.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Press:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAuthor.Location = new System.Drawing.Point(410, 576);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(126, 17);
            this.txtAuthor.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Author:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(410, 546);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(126, 17);
            this.txtName.TabIndex = 29;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(401, 480);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(174, 19);
            this.txtISBN.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "ISBN:";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBook.Location = new System.Drawing.Point(10, 392);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(281, 242);
            this.dgvBook.TabIndex = 8;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // btnALL
            // 
            this.btnALL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnALL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnALL.FlatAppearance.BorderSize = 0;
            this.btnALL.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnALL.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnALL.Location = new System.Drawing.Point(4, 248);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(51, 36);
            this.btnALL.TabIndex = 42;
            this.btnALL.Text = "All";
            this.btnALL.UseVisualStyleBackColor = false;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(155, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(384, 601);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(83, 33);
            this.btnChange.TabIndex = 45;
            this.btnChange.Text = "Exit";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(524, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStock.Location = new System.Drawing.Point(594, 576);
            this.txtStock.MaxLength = 5;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(95, 17);
            this.txtStock.TabIndex = 64;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(537, 575);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 63;
            this.label11.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Name:";
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(216, 248);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 36);
            this.btnQuit.TabIndex = 66;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(62, 278);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(87, 36);
            this.btnModify.TabIndex = 68;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(155, 281);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 33);
            this.btnUser.TabIndex = 69;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(692, 647);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPressDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.lblSearchWay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Management";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label lblKeyWord;
        private System.Windows.Forms.Label lblSearchWay;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPressDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.OpenFileDialog ofdViewPic;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnUser;
    }
}