using System.Windows.Forms;

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
            this.newTransaksi1 = new SerbuComputer.NewTransaksi();
            this.managementProductAdmin1 = new SerbuComputer.ManagementProductAdmin();
            this.newTransaksi2 = new SerbuComputer.NewTransaksi();
            this.panelContent = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(251, 1024);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.bMembers.Location = new System.Drawing.Point(0, 455);
            this.bMembers.Name = "bMembers";
            this.bMembers.Size = new System.Drawing.Size(245, 94);
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
            this.bTransactions.Location = new System.Drawing.Point(0, 357);
            this.bTransactions.Name = "bTransactions";
            this.bTransactions.Size = new System.Drawing.Size(248, 92);
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
            this.bProduct.Location = new System.Drawing.Point(0, 258);
            this.bProduct.Name = "bProduct";
            this.bProduct.Size = new System.Drawing.Size(251, 92);
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
            this.bDashboard.Location = new System.Drawing.Point(3, 152);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(248, 93);
            this.bDashboard.TabIndex = 0;
            this.bDashboard.Text = "Home";
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 959);
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
            this.bLogout.Location = new System.Drawing.Point(49, 934);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(196, 88);
            this.bLogout.TabIndex = 4;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = false;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerbuComputer.Properties.Resources.Gemini_Generated_Image_9d3iqj9d3iqj9d3i_removebg_preview_31;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(105)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1647, 151);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // newTransaksi1
            // 
            this.newTransaksi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newTransaksi1.Location = new System.Drawing.Point(251, 151);
            this.newTransaksi1.Name = "newTransaksi1";
            this.newTransaksi1.Size = new System.Drawing.Size(1647, 873);
            this.newTransaksi1.TabIndex = 6;
            // 
            // managementProductAdmin1
            // 
            this.managementProductAdmin1.Location = new System.Drawing.Point(251, 157);
            this.managementProductAdmin1.Name = "managementProductAdmin1";
            this.managementProductAdmin1.Size = new System.Drawing.Size(1644, 891);
            this.managementProductAdmin1.TabIndex = 7;
            // 
            // newTransaksi2
            // 
            this.newTransaksi2.Location = new System.Drawing.Point(251, 157);
            this.newTransaksi2.Name = "newTransaksi2";
            this.newTransaksi2.Size = new System.Drawing.Size(1644, 896);
            this.newTransaksi2.TabIndex = 8;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(251, 153);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1644, 892);
            this.panelContent.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.newTransaksi2);
            this.Controls.Add(this.managementProductAdmin1);
            this.Controls.Add(this.newTransaksi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "a";
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
        public NewTransaksi newTransaksi1;
        public ManagementProductAdmin managementProductAdmin1;
        public NewTransaksi transactionOfflineAdmin1;
        private NewTransaksi newTransaksi2;
        private Panel panelContent;
    }
}

