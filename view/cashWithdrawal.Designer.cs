namespace Bank_System.view
{
    partial class cashWithdrawal
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
            this.cash = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cash_withdrawal = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crruncy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.installmentformonth = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personalacc = new System.Windows.Forms.RadioButton();
            this.companyacc = new System.Windows.Forms.RadioButton();
            this.arabic_cash = new System.Windows.Forms.TextBox();
            this.arabic_installment = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(421, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "الرصيد الحالي";
            // 
            // cash
            // 
            this.cash.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cash.Location = new System.Drawing.Point(148, 191);
            this.cash.Margin = new System.Windows.Forms.Padding(6);
            this.cash.Name = "cash";
            this.cash.ReadOnly = true;
            this.cash.Size = new System.Drawing.Size(229, 29);
            this.cash.TabIndex = 3;
            this.cash.Text = "50,000";
            this.cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "كشف معاملات";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "مبلغ السحب";
            // 
            // cash_withdrawal
            // 
            this.cash_withdrawal.Location = new System.Drawing.Point(148, 379);
            this.cash_withdrawal.Margin = new System.Windows.Forms.Padding(6);
            this.cash_withdrawal.Name = "cash_withdrawal";
            this.cash_withdrawal.Size = new System.Drawing.Size(229, 29);
            this.cash_withdrawal.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "سحب";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "اسم صاحب الحساب";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.name.Location = new System.Drawing.Point(148, 106);
            this.name.Margin = new System.Windows.Forms.Padding(6);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(228, 29);
            this.name.TabIndex = 9;
            this.name.Text = "اسم تجريبي";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "العملة";
            // 
            // crruncy
            // 
            this.crruncy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.crruncy.Location = new System.Drawing.Point(148, 147);
            this.crruncy.Margin = new System.Windows.Forms.Padding(6);
            this.crruncy.Name = "crruncy";
            this.crruncy.ReadOnly = true;
            this.crruncy.Size = new System.Drawing.Size(228, 29);
            this.crruncy.TabIndex = 11;
            this.crruncy.Text = "الجنية المصري";
            this.crruncy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "قسط مطلوب لهذا الشهر";
            // 
            // installmentformonth
            // 
            this.installmentformonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.installmentformonth.Location = new System.Drawing.Point(148, 264);
            this.installmentformonth.Margin = new System.Windows.Forms.Padding(6);
            this.installmentformonth.Name = "installmentformonth";
            this.installmentformonth.ReadOnly = true;
            this.installmentformonth.Size = new System.Drawing.Size(213, 29);
            this.installmentformonth.TabIndex = 13;
            this.installmentformonth.Text = "لا يوجد";
            this.installmentformonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "سداد";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.personalacc);
            this.panel1.Controls.Add(this.companyacc);
            this.panel1.Location = new System.Drawing.Point(105, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 34);
            this.panel1.TabIndex = 19;
            // 
            // personalacc
            // 
            this.personalacc.AutoSize = true;
            this.personalacc.Checked = true;
            this.personalacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalacc.Location = new System.Drawing.Point(3, 6);
            this.personalacc.Name = "personalacc";
            this.personalacc.Size = new System.Drawing.Size(112, 24);
            this.personalacc.TabIndex = 1;
            this.personalacc.TabStop = true;
            this.personalacc.Text = "حساب شخصي";
            this.personalacc.UseVisualStyleBackColor = true;
            // 
            // companyacc
            // 
            this.companyacc.AutoSize = true;
            this.companyacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyacc.Location = new System.Drawing.Point(212, 6);
            this.companyacc.Name = "companyacc";
            this.companyacc.Size = new System.Drawing.Size(110, 24);
            this.companyacc.TabIndex = 0;
            this.companyacc.Text = "حساب مؤسسة";
            this.companyacc.UseVisualStyleBackColor = true;
            // 
            // arabic_cash
            // 
            this.arabic_cash.BackColor = System.Drawing.SystemColors.ControlDark;
            this.arabic_cash.Location = new System.Drawing.Point(12, 223);
            this.arabic_cash.Margin = new System.Windows.Forms.Padding(6);
            this.arabic_cash.Name = "arabic_cash";
            this.arabic_cash.ReadOnly = true;
            this.arabic_cash.Size = new System.Drawing.Size(518, 29);
            this.arabic_cash.TabIndex = 20;
            this.arabic_cash.Text = "50,000";
            this.arabic_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // arabic_installment
            // 
            this.arabic_installment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.arabic_installment.Location = new System.Drawing.Point(12, 297);
            this.arabic_installment.Margin = new System.Windows.Forms.Padding(6);
            this.arabic_installment.Name = "arabic_installment";
            this.arabic_installment.ReadOnly = true;
            this.arabic_installment.Size = new System.Drawing.Size(518, 29);
            this.arabic_installment.TabIndex = 24;
            this.arabic_installment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 32);
            this.panel2.TabIndex = 23;
            this.panel2.Visible = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.SystemColors.GrayText;
            this.date.ForeColor = System.Drawing.Color.Azure;
            this.date.Location = new System.Drawing.Point(91, 5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(99, 24);
            this.date.TabIndex = 20;
            this.date.Text = "11/9/2001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GrayText;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(198, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "قسط من قرض إتماني بتاريخ ";
            // 
            // cashWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(554, 100);
            this.Controls.Add(this.arabic_installment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.arabic_cash);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.installmentformonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crruncy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cash_withdrawal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "cashWithdrawal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب مالي";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cash_withdrawal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox crruncy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox installmentformonth;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton personalacc;
        private System.Windows.Forms.RadioButton companyacc;
        private System.Windows.Forms.TextBox arabic_cash;
        private System.Windows.Forms.TextBox arabic_installment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label7;
    }
}