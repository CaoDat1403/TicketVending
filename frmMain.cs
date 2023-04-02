using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TicketVending
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmQRCode fqr = new frmQRCode();
            CreditCard fcc = new CreditCard();
            if (QRCode.Checked == true)
            {
                fqr.ShowDialog();
            }
            else if(CreditCard.Checked == true)
            {
                fcc.ShowDialog();
            }else if(QRCode.Checked = CreditCard.Checked == false)
            {
                DialogResult result = MessageBox.Show("Please choose payment methods", "Warning", MessageBoxButtons.OKCancel);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
                
        }

        private void CreditCard_CheckedChanged(object sender, EventArgs e)
        {
            QRCode.Checked = !CreditCard.Checked;
        }

        private void QRCode_CheckedChanged(object sender, EventArgs e)
        {
            CreditCard.Checked = !QRCode.Checked;
        }
    }
}
