using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVending
{
    public partial class CreditCard : Form
    {
        public CreditCard()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool allFilled = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        allFilled = false;
                        break;
                    }
                }
            }
            if (allFilled)
            {
                DialogResult result = MessageBox.Show("Are you sure with the transaction ? Once the payment has been completed, you can not refund ","Warning",MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    System.Threading.Thread.Sleep(3000);
                    MessageBox.Show("Thank you for choosing our service !!!", "Process successfully !");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the information", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
