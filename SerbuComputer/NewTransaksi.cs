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
    public partial class NewTransaksi : UserControl
    {
        public NewTransaksi()
        {
            InitializeComponent();
        }

        private void bAddTransaction_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.transactionOfflineAdmin1.BringToFront();
        }

        private void bProfileTransaksi_Click(object sender, EventArgs e)
        {
            ViewMember popup = new ViewMember();

            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                popup.StartPosition = FormStartPosition.Manual;

                // Logika perhitungan posisi tengah:
                // (Titik Awal Parent + Setengah Lebar Parent) - Setengah Lebar Popup
                int centerX = parentForm.Location.X + (parentForm.Width / 2) - (popup.Width / 2);
                int centerY = parentForm.Location.Y + (parentForm.Height / 2) - (popup.Height / 2);

                popup.Location = new Point(centerX, centerY);
            }
            else
            {
                // Jika parent tidak ditemukan, muncul di tengah layar monitor
                popup.StartPosition = FormStartPosition.CenterScreen;
            }

            popup.ShowDialog();
        }

        private void bProfileTransaction1_Click(object sender, EventArgs e)
        {
            ViewMember popup = new ViewMember();

            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                popup.StartPosition = FormStartPosition.Manual;

                // Logika perhitungan posisi tengah:
                // (Titik Awal Parent + Setengah Lebar Parent) - Setengah Lebar Popup
                int centerX = parentForm.Location.X + (parentForm.Width / 2) - (popup.Width / 2);
                int centerY = parentForm.Location.Y + (parentForm.Height / 2) - (popup.Height / 2);

                popup.Location = new Point(centerX, centerY);
            }
            else
            {
                // Jika parent tidak ditemukan, muncul di tengah layar monitor
                popup.StartPosition = FormStartPosition.CenterScreen;
            }

            popup.ShowDialog();
        }

        private void bProof_Click(object sender, EventArgs e)
        {
            ProofTransaction popup = new ProofTransaction();

            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                popup.StartPosition = FormStartPosition.Manual;

                // Logika perhitungan posisi tengah:
                // (Titik Awal Parent + Setengah Lebar Parent) - Setengah Lebar Popup
                int centerX = parentForm.Location.X + (parentForm.Width / 2) - (popup.Width / 2);
                int centerY = parentForm.Location.Y + (parentForm.Height / 2) - (popup.Height / 2);

                popup.Location = new Point(centerX, centerY);
            }
            else
            {
                // Jika parent tidak ditemukan, muncul di tengah layar monitor
                popup.StartPosition = FormStartPosition.CenterScreen;
            }

            popup.ShowDialog();
        }
    }
}
