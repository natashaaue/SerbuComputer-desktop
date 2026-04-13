namespace SerbuComputer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bMembers = new Guna.UI2.WinForms.Guna2Button();
            this.bTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.bProduct = new Guna.UI2.WinForms.Guna2Button();
            this.bDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.newTransaksi1 = new SerbuComputer.NewTransaksi();
            this.katalogProductAdmin1 = new SerbuComputer.KatalogProductAdmin();
            this.transactionOfflineAdmin1 = new SerbuComputer.TransactionOfflineAdmin();
            this.managementProductAdmin1 = new SerbuComputer.ManagementProductAdmin();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.bMembers);
            this.panel1.Controls.Add(this.bTransactions);
            this.panel1.Controls.Add(this.bProduct);
            this.panel1.Controls.Add(this.bDashboard);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1024);
            this.panel1.TabIndex = 0;
            // 
            // bMembers
            // 
            this.bMembers.BackColor = System.Drawing.Color.Transparent;
            this.bMembers.BorderRadius = 10;
            this.bMembers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bMembers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bMembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bMembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bMembers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.bMembers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(43)))));
            this.bMembers.Location = new System.Drawing.Point(-2, 439);
            this.bMembers.Name = "bMembers";
            this.bMembers.Size = new System.Drawing.Size(202, 83);
            this.bMembers.TabIndex = 7;
            this.bMembers.Text = "Members";
            this.bMembers.Click += new System.EventHandler(this.bUsers_Click);
            // 
            // bTransactions
            // 
            this.bTransactions.BackColor = System.Drawing.Color.Transparent;
            this.bTransactions.BorderRadius = 10;
            this.bTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bTransactions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.bTransactions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(43)))));
            this.bTransactions.Location = new System.Drawing.Point(-1, 334);
            this.bTransactions.Name = "bTransactions";
            this.bTransactions.Size = new System.Drawing.Size(202, 83);
            this.bTransactions.TabIndex = 6;
            this.bTransactions.Text = "Transactions";
            this.bTransactions.Click += new System.EventHandler(this.bTransactions_Click);
            // 
            // bProduct
            // 
            this.bProduct.BackColor = System.Drawing.Color.Transparent;
            this.bProduct.BorderRadius = 10;
            this.bProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.bProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(43)))));
            this.bProduct.Location = new System.Drawing.Point(-4, 236);
            this.bProduct.Name = "bProduct";
            this.bProduct.Size = new System.Drawing.Size(205, 83);
            this.bProduct.TabIndex = 5;
            this.bProduct.Text = "Product";
            this.bProduct.Click += new System.EventHandler(this.bProduct_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.BackColor = System.Drawing.Color.Transparent;
            this.bDashboard.BorderRadius = 10;
            this.bDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.bDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(43)))));
            this.bDashboard.Location = new System.Drawing.Point(-2, 137);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(205, 83);
            this.bDashboard.TabIndex = 0;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 959);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bLogout
            // 
            this.bLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.bLogout.FlatAppearance.BorderSize = 0;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(178)))), ((int)(((byte)(43)))));
            this.bLogout.Location = new System.Drawing.Point(39, 936);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(161, 88);
            this.bLogout.TabIndex = 4;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = false;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerbuComputer.Properties.Resources.Gemini_Generated_Image_9d3iqj9d3iqj9d3i_removebg_preview_31;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1698, 100);
            this.panel2.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1698, 924);
            this.panelContent.TabIndex = 7;
            // 
            // newTransaksi1
            // 
            this.newTransaksi1.Location = new System.Drawing.Point(200, 99);
            this.newTransaksi1.Name = "newTransaksi1";
            this.newTransaksi1.Size = new System.Drawing.Size(1698, 921);
            this.newTransaksi1.TabIndex = 6;
            // 
            // katalogProductAdmin1
            // 
            this.katalogProductAdmin1.Location = new System.Drawing.Point(201, 101);
            this.katalogProductAdmin1.Name = "katalogProductAdmin1";
            this.katalogProductAdmin1.Size = new System.Drawing.Size(1698, 921);
            this.katalogProductAdmin1.TabIndex = 5;
            // 
            // transactionOfflineAdmin1
            // 
            this.transactionOfflineAdmin1.Location = new System.Drawing.Point(200, 102);
            this.transactionOfflineAdmin1.Name = "transactionOfflineAdmin1";
            this.transactionOfflineAdmin1.Size = new System.Drawing.Size(1887, 967);
            this.transactionOfflineAdmin1.TabIndex = 4;
            // 
            // managementProductAdmin1
            // 
            this.managementProductAdmin1.AutoScroll = true;
            this.managementProductAdmin1.Location = new System.Drawing.Point(200, 103);
            this.managementProductAdmin1.Name = "managementProductAdmin1";
            this.managementProductAdmin1.Size = new System.Drawing.Size(1887, 967);
            this.managementProductAdmin1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.newTransaksi1);
            this.Controls.Add(this.katalogProductAdmin1);
            this.Controls.Add(this.transactionOfflineAdmin1);
            this.Controls.Add(this.managementProductAdmin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button bDashboard;
        private Guna.UI2.WinForms.Guna2Button bProduct;
        private Guna.UI2.WinForms.Guna2Button bMembers;
        private Guna.UI2.WinForms.Guna2Button bTransactions;
        public ManagementProductAdmin managementProductAdmin1;
        public TransactionOfflineAdmin transactionOfflineAdmin1;
        public KatalogProductAdmin katalogProductAdmin1;
        public NewTransaksi newTransaksi1;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
    }
}

