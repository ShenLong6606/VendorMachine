namespace VendorMachine
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
            this.Title = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListPay = new System.Windows.Forms.CheckedListBox();
            this.Book = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.Title.Location = new System.Drawing.Point(273, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(260, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Bus Ticket Vendor";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chợ Bà Hom - Q.Bình Tân",
            "Chợ Bình Tây - Q6",
            "Chợ Bến Thành - Q1",
            "Sân bay Tân Sơn Nhất",
            "Khu vui chơi Đầm Sen",
            "Khu vui chơi Suối Tiên",
            "AEON Mall Bình Tân",
            "AEON Mall Tân Phú"});
            this.comboBox1.Location = new System.Drawing.Point(29, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkedListPay
            // 
            this.checkedListPay.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.checkedListPay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListPay.FormattingEnabled = true;
            this.checkedListPay.Items.AddRange(new object[] {
            "Credit card",
            "QR code"});
            this.checkedListPay.Location = new System.Drawing.Point(29, 204);
            this.checkedListPay.Name = "checkedListPay";
            this.checkedListPay.Size = new System.Drawing.Size(153, 64);
            this.checkedListPay.TabIndex = 11;
            this.checkedListPay.SelectedIndexChanged += new System.EventHandler(this.checkedListPay_SelectedIndexChanged);
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Book.Location = new System.Drawing.Point(29, 320);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(116, 39);
            this.Book.TabIndex = 12;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.linkLabel1.Location = new System.Drawing.Point(24, 412);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(372, 29);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here for some waiting music";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendorMachine.Properties.Resources._1957__2_;
            this.pictureBox1.Location = new System.Drawing.Point(383, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.checkedListPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListPay;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

