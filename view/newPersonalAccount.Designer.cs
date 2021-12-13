namespace Bank_System.view
{
    partial class newPersonalAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPersonalAccount));
            this.nationalID_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tradeReport_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richNote = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chequeCheck = new System.Windows.Forms.CheckBox();
            this.visaCheck = new System.Windows.Forms.CheckBox();
            this.accountReport = new System.Windows.Forms.ComboBox();
            this.crruncy = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tradeReportPath = new System.Windows.Forms.TextBox();
            this.idPath = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.nationalID = new System.Windows.Forms.TextBox();
            this.national = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nationalID_FileDialog
            // 
            this.nationalID_FileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // tradeReport_FileDialog
            // 
            this.tradeReport_FileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // richNote
            // 
            this.richNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNote.Location = new System.Drawing.Point(10, 362);
            this.richNote.Name = "richNote";
            this.richNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richNote.Size = new System.Drawing.Size(418, 133);
            this.richNote.TabIndex = 39;
            this.richNote.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(78, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "إنشاء الحساب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chequeCheck
            // 
            this.chequeCheck.AutoSize = true;
            this.chequeCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chequeCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeCheck.Location = new System.Drawing.Point(257, 316);
            this.chequeCheck.Name = "chequeCheck";
            this.chequeCheck.Size = new System.Drawing.Size(169, 24);
            this.chequeCheck.TabIndex = 37;
            this.chequeCheck.Text = "اصدار دفتر شيكات";
            this.chequeCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chequeCheck.UseVisualStyleBackColor = true;
            // 
            // visaCheck
            // 
            this.visaCheck.AutoSize = true;
            this.visaCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.visaCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaCheck.Location = new System.Drawing.Point(12, 316);
            this.visaCheck.Name = "visaCheck";
            this.visaCheck.Size = new System.Drawing.Size(171, 24);
            this.visaCheck.TabIndex = 36;
            this.visaCheck.Text = "اصدار بطاقة دفع   ";
            this.visaCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.visaCheck.UseVisualStyleBackColor = true;
            // 
            // accountReport
            // 
            this.accountReport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.accountReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountReport.FormattingEnabled = true;
            this.accountReport.Items.AddRange(new object[] {
            "ربع سنوي",
            "سنوي",
            "نصف سنوي"});
            this.accountReport.Location = new System.Drawing.Point(12, 175);
            this.accountReport.Name = "accountReport";
            this.accountReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountReport.Size = new System.Drawing.Size(188, 27);
            this.accountReport.Sorted = true;
            this.accountReport.TabIndex = 35;
            // 
            // crruncy
            // 
            this.crruncy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.crruncy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crruncy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crruncy.FormattingEnabled = true;
            this.crruncy.Items.AddRange(new object[] {
            "الجنية المصري",
            "الدولار الامريكي",
            "اليورو"});
            this.crruncy.Location = new System.Drawing.Point(10, 114);
            this.crruncy.Name = "crruncy";
            this.crruncy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.crruncy.Size = new System.Drawing.Size(188, 27);
            this.crruncy.Sorted = true;
            this.crruncy.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "كشف الحساب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "السجل التجاري | مفردات المرتب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "العملة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "بطاقة الرقم القومي | جواز السفر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "مبلغ الايداع";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "الملاحظات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "المهنة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "الرقم القومي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "الجنسية";
            // 
            // tradeReportPath
            // 
            this.tradeReportPath.BackColor = System.Drawing.Color.Gainsboro;
            this.tradeReportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tradeReportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeReportPath.Location = new System.Drawing.Point(285, 275);
            this.tradeReportPath.Name = "tradeReportPath";
            this.tradeReportPath.ReadOnly = true;
            this.tradeReportPath.Size = new System.Drawing.Size(143, 26);
            this.tradeReportPath.TabIndex = 16;
            this.tradeReportPath.Text = "اختار صورة";
            this.tradeReportPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idPath
            // 
            this.idPath.BackColor = System.Drawing.Color.Gainsboro;
            this.idPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPath.Location = new System.Drawing.Point(285, 175);
            this.idPath.Name = "idPath";
            this.idPath.ReadOnly = true;
            this.idPath.Size = new System.Drawing.Size(143, 26);
            this.idPath.TabIndex = 15;
            this.idPath.Text = "اختار صورة";
            this.idPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cash
            // 
            this.cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(10, 241);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(188, 26);
            this.cash.TabIndex = 14;
            this.cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "الاسم الكامل";
            // 
            // job
            // 
            this.job.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.job.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job.Location = new System.Drawing.Point(221, 219);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(207, 26);
            this.job.TabIndex = 13;
            this.job.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nationalID
            // 
            this.nationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nationalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalID.Location = new System.Drawing.Point(221, 131);
            this.nationalID.Name = "nationalID";
            this.nationalID.Size = new System.Drawing.Size(207, 26);
            this.nationalID.TabIndex = 12;
            this.nationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // national
            // 
            this.national.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.national.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.national.Location = new System.Drawing.Point(221, 85);
            this.national.Name = "national";
            this.national.Size = new System.Drawing.Size(207, 26);
            this.national.TabIndex = 17;
            this.national.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullName
            // 
            this.fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(126, 33);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(302, 26);
            this.fullName.TabIndex = 11;
            this.fullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Bank_System.Properties.Resources.preview;
            this.pictureBox4.Location = new System.Drawing.Point(257, 275);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Bank_System.Properties.Resources.preview;
            this.pictureBox1.Location = new System.Drawing.Point(257, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Bank_System.Properties.Resources.eyepreview;
            this.pictureBox3.Location = new System.Drawing.Point(221, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Bank_System.Properties.Resources.eyepreview;
            this.pictureBox2.Location = new System.Drawing.Point(221, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // newPersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(438, 570);
            this.Controls.Add(this.richNote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chequeCheck);
            this.Controls.Add(this.visaCheck);
            this.Controls.Add(this.accountReport);
            this.Controls.Add(this.crruncy);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tradeReportPath);
            this.Controls.Add(this.idPath);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.job);
            this.Controls.Add(this.nationalID);
            this.Controls.Add(this.national);
            this.Controls.Add(this.fullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newPersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حساب شخصي جديد";
            this.Load += new System.EventHandler(this.newPersonalAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion
        private System.Windows.Forms.OpenFileDialog nationalID_FileDialog;
        private System.Windows.Forms.OpenFileDialog tradeReport_FileDialog;
        private System.Windows.Forms.RichTextBox richNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chequeCheck;
        private System.Windows.Forms.CheckBox visaCheck;
        private System.Windows.Forms.ComboBox accountReport;
        private System.Windows.Forms.ComboBox crruncy;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tradeReportPath;
        private System.Windows.Forms.TextBox idPath;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.TextBox nationalID;
        private System.Windows.Forms.TextBox national;
        private System.Windows.Forms.TextBox fullName;
    }
}