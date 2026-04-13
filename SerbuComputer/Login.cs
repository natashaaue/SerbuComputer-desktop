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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bSignin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "12345")
            {
                Form1 Biodata = new Form1();
                Biodata.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Password Salah");
            }
        }
    }
}
