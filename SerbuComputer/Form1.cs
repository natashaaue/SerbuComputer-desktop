using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerbuComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPage(UserControl page)
        {
            // Bersihkan konten sebelumnya
            panelContent.Controls.Clear();

            // Atur agar UserControl menyesuaikan ukuran panel
            page.Dock = DockStyle.Fill;

            // Tambahkan UserControl ke panel
            panelContent.Controls.Add(page);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPage(new DashboardAdmin());
        }


        private void bDashboard_Click(object sender, EventArgs e)
        {

        }

        private void bDashboard_Click_1(object sender, EventArgs e)
        {
            ShowPage(new DashboardAdmin());
            bMembers.FillColor = Color.FromArgb(9, 0, 105);
            bProduct.FillColor = Color.FromArgb(9, 0, 105);
            bTransactions.FillColor = Color.FromArgb(9, 0, 105);
            bDashboard.FillColor = Color.FromArgb(240, 178, 43);

            bProduct.ForeColor = Color.FromArgb(240, 178, 43);
            bMembers.ForeColor = Color.FromArgb(240, 178, 43);
            bTransactions.ForeColor = Color.FromArgb(240, 178, 43);
            bDashboard.ForeColor = Color.FromArgb(9, 0, 105);
        }

        private void bProduct_Click(object sender, EventArgs e)
        {
            ShowPage(new KatalogProductAdmin());
            bMembers.FillColor = Color.FromArgb(9, 0, 105);
            bDashboard.FillColor = Color.FromArgb(9, 0, 105);
            bTransactions.FillColor = Color.FromArgb(9, 0, 105);
            bProduct.FillColor = Color.FromArgb(240, 178, 43);

            bDashboard.ForeColor = Color.FromArgb(240, 178, 43);
            bMembers.ForeColor = Color.FromArgb(240, 178, 43);
            bTransactions.ForeColor = Color.FromArgb(240, 178, 43);
            bProduct.ForeColor = Color.FromArgb(9, 0, 105);
        }

        private void bTransactions_Click(object sender, EventArgs e)
        {
            ShowPage(new NewTransaksi());
            bMembers.FillColor = Color.FromArgb(9, 0, 105);
            bProduct.FillColor = Color.FromArgb(9, 0, 105);
            bDashboard.FillColor = Color.FromArgb(9, 0, 105);
            bTransactions.FillColor = Color.FromArgb(240, 178, 43);

            bProduct.ForeColor = Color.FromArgb(240, 178, 43);
            bMembers.ForeColor = Color.FromArgb(240, 178, 43);
            bDashboard.ForeColor = Color.FromArgb(240, 178, 43);
            bTransactions.ForeColor = Color.FromArgb(9, 0, 105);
        }

        private void bUsers_Click(object sender, EventArgs e)
        {
            ShowPage(new ManagementMemberAdmind());
            bDashboard.FillColor = Color.FromArgb(9, 0, 105);
            bProduct.FillColor = Color.FromArgb(9, 0, 105);
            bTransactions.FillColor = Color.FromArgb(9, 0, 105);
            bMembers.FillColor = Color.FromArgb(240, 178, 43);

            bProduct.ForeColor = Color.FromArgb(240, 178, 43);
            bDashboard.ForeColor = Color.FromArgb(240, 178, 43);
            bTransactions.ForeColor = Color.FromArgb(240, 178, 43);
            bMembers.ForeColor = Color.FromArgb(9, 0, 105);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
