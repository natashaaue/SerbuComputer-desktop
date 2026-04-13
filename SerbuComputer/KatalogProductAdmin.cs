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
    public partial class KatalogProductAdmin : UserControl
    {
        public KatalogProductAdmin()
        {
            InitializeComponent();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.managementProductAdmin1.BringToFront();
        }

        private void pictAction_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.managementProductAdmin1.BringToFront();
        }

        private void pictAction1_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.managementProductAdmin1.BringToFront();
        }
    }
}
