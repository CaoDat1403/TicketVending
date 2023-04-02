namespace TicketVending
{
    partial class frmMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPaymentMethods = new System.Windows.Forms.Label();
            this.CreditCard = new System.Windows.Forms.CheckBox();
            this.QRCode = new System.Windows.Forms.CheckBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chợ Lớn - Q6",
            "Chợ Bình Tây - Q6",
            "Chợ Bến Thành - Q1",
            "Chợ Hồ Thị Kỉ - Q10",
            "Tân Sơn Nhất",
            "Đầm Sen",
            "AEON Mall Bình Tân",
            "AEON Mall Tân Bình"});
            this.comboBox1.Location = new System.Drawing.Point(167, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(492, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(565, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ticket Vending Machine for Public Bus";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(30, 135);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(111, 24);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destinations";
            // 
            // lblPaymentMethods
            // 
            this.lblPaymentMethods.AutoSize = true;
            this.lblPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethods.Location = new System.Drawing.Point(0, 226);
            this.lblPaymentMethods.Name = "lblPaymentMethods";
            this.lblPaymentMethods.Size = new System.Drawing.Size(161, 24);
            this.lblPaymentMethods.TabIndex = 3;
            this.lblPaymentMethods.Text = "Payment Methods";
            // 
            // CreditCard
            // 
            this.CreditCard.AutoSize = true;
            this.CreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCard.Location = new System.Drawing.Point(167, 222);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(123, 28);
            this.CreditCard.TabIndex = 4;
            this.CreditCard.Text = "Credit Card";
            this.CreditCard.UseVisualStyleBackColor = true;
            this.CreditCard.CheckedChanged += new System.EventHandler(this.CreditCard_CheckedChanged);
            // 
            // QRCode
            // 
            this.QRCode.AutoSize = true;
            this.QRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRCode.Location = new System.Drawing.Point(524, 226);
            this.QRCode.Name = "QRCode";
            this.QRCode.Size = new System.Drawing.Size(135, 28);
            this.QRCode.TabIndex = 5;
            this.QRCode.Text = "Digital Wallet";
            this.QRCode.UseVisualStyleBackColor = true;
            this.QRCode.CheckedChanged += new System.EventHandler(this.QRCode_CheckedChanged);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(167, 300);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(123, 32);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(536, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.QRCode);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.lblPaymentMethods);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPaymentMethods;
        private System.Windows.Forms.CheckBox CreditCard;
        private System.Windows.Forms.CheckBox QRCode;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
    }
}

