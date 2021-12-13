namespace Bank_System.view
{
    partial class releaseCreditcard
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
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.notHaveVisa = new System.Windows.Forms.GroupBox();
            this.cardPreview = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cardExpDate = new System.Windows.Forms.Label();
            this.cardOwnerName = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notHaveVisa.SuspendLayout();
            this.cardPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountNumber
            // 
            this.accountNumber.Location = new System.Drawing.Point(105, 24);
            this.accountNumber.Margin = new System.Windows.Forms.Padding(6);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(325, 29);
            this.accountNumber.TabIndex = 0;
            this.accountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الحساب";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "الرصيد الحالي";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(75, 194);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(229, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "50,000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(80, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "لا يملك هذا الحساب بطاقة دفع ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = " اصدار بطاقة دفع ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "اسم صاحب الحساب";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Location = new System.Drawing.Point(75, 109);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(228, 29);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "اسم تجريبي";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "العملة";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Location = new System.Drawing.Point(75, 150);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(228, 29);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "الجنية المصري";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // notHaveVisa
            // 
            this.notHaveVisa.Controls.Add(this.button3);
            this.notHaveVisa.Controls.Add(this.label3);
            this.notHaveVisa.Location = new System.Drawing.Point(75, 232);
            this.notHaveVisa.Name = "notHaveVisa";
            this.notHaveVisa.Size = new System.Drawing.Size(382, 130);
            this.notHaveVisa.TabIndex = 13;
            this.notHaveVisa.TabStop = false;
            // 
            // cardPreview
            // 
            this.cardPreview.Controls.Add(this.button4);
            this.cardPreview.Controls.Add(this.button2);
            this.cardPreview.Controls.Add(this.cardExpDate);
            this.cardPreview.Controls.Add(this.cardOwnerName);
            this.cardPreview.Controls.Add(this.cardNumber);
            this.cardPreview.Controls.Add(this.pictureBox1);
            this.cardPreview.Location = new System.Drawing.Point(32, 232);
            this.cardPreview.Name = "cardPreview";
            this.cardPreview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cardPreview.Size = new System.Drawing.Size(483, 374);
            this.cardPreview.TabIndex = 14;
            this.cardPreview.TabStop = false;
            this.cardPreview.Text = "معاينة البطاقة";
            this.cardPreview.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "طباعة بدل فاقد";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "تعطيل البطاقة";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cardExpDate
            // 
            this.cardExpDate.AutoSize = true;
            this.cardExpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(96)))));
            this.cardExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardExpDate.Location = new System.Drawing.Point(30, 279);
            this.cardExpDate.Name = "cardExpDate";
            this.cardExpDate.Size = new System.Drawing.Size(109, 24);
            this.cardExpDate.TabIndex = 18;
            this.cardExpDate.Text = "Exp: 11/22";
            // 
            // cardOwnerName
            // 
            this.cardOwnerName.AutoSize = true;
            this.cardOwnerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(119)))), ((int)(((byte)(208)))));
            this.cardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardOwnerName.Location = new System.Drawing.Point(90, 231);
            this.cardOwnerName.Name = "cardOwnerName";
            this.cardOwnerName.Size = new System.Drawing.Size(246, 29);
            this.cardOwnerName.TabIndex = 17;
            this.cardOwnerName.Text = "Abdulrhman Elfallah";
            // 
            // cardNumber
            // 
            this.cardNumber.AutoSize = true;
            this.cardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(162)))));
            this.cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cardNumber.Location = new System.Drawing.Point(28, 186);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(294, 31);
            this.cardNumber.TabIndex = 16;
            this.cardNumber.Text = "8444 5535 5466 6642";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_System.Properties.Resources.card;
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 297);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // releaseCreditcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(554, 65);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.notHaveVisa);
            this.Controls.Add(this.cardPreview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "releaseCreditcard";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " بطاقة إتمان";
            this.notHaveVisa.ResumeLayout(false);
            this.notHaveVisa.PerformLayout();
            this.cardPreview.ResumeLayout(false);
            this.cardPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox notHaveVisa;
        private System.Windows.Forms.GroupBox cardPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cardExpDate;
        private System.Windows.Forms.Label cardOwnerName;
        private System.Windows.Forms.Label cardNumber;
    }
}