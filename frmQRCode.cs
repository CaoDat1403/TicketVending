using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;
namespace TicketVending
{
    public partial class frmQRCode : Form
    {
        public frmQRCode()
        {
            InitializeComponent();
        }

        private void frmQRCode_Load(object sender, EventArgs e)
        {
            BarcodeWriter bcw = new BarcodeWriter();
            bcw.Format = BarcodeFormat.QR_CODE;
            string filePath = @"C:\Cao Dat\Year 2\Software Engineering\QT1\CuteCat.png";
            bcw.Write("https://www.youtube.com/watch?v=pr-f1MHqwBM").Save(filePath);

            using (var tempImage = Image.FromFile(filePath))
            {
                pictureQR.Image = new Bitmap(tempImage);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To start the printing ticket process, please press the OK button to continue","Continue ?");

            // Pause the current thread for 3 seconds (3000 milliseconds)
            System.Threading.Thread.Sleep(3000);

            DialogResult result = MessageBox.Show("Thank you for choosing our service !!!", "Process successfully !", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
