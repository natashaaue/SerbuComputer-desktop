namespace SerbuComputer
{
    partial class ProofTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProofTransaction));
            this.PictureProofTransaction = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProofTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureProofTransaction
            // 
            this.PictureProofTransaction.Image = ((System.Drawing.Image)(resources.GetObject("PictureProofTransaction.Image")));
            this.PictureProofTransaction.ImageRotate = 0F;
            this.PictureProofTransaction.Location = new System.Drawing.Point(3, 2);
            this.PictureProofTransaction.Name = "PictureProofTransaction";
            this.PictureProofTransaction.Size = new System.Drawing.Size(413, 718);
            this.PictureProofTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureProofTransaction.TabIndex = 0;
            this.PictureProofTransaction.TabStop = false;
            // 
            // ProofTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 726);
            this.Controls.Add(this.PictureProofTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProofTransaction";
            this.Text = "ProofTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.PictureProofTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureProofTransaction;
    }
}