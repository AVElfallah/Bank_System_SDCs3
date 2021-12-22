using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.view
{
    public partial class releaseCreditcard : Form
    {
        model.personalAccount personal;
        public releaseCreditcard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personal = db.personalAccountDB.getAccountDataByID(accountNumber.Text);
            if (personal != null)
            {
                if (personal.isHaveVisa)
                {
                    cardPreview.Visible = true;
                    notHaveVisa.Visible = false;
                    personal.accountVisa = db.personalAccountDB.getVisaByID(accountNumber.Text);
                    cardNumber.Text = personal.accountVisa.visaNumber;
                    cardExpDate.Text = personal.accountVisa.expDate;
                    cardOwnerName.Text = personal.accountVisa.nameInVisa;


                }
                else
                {
                    cardPreview.Visible = false;
                    notHaveVisa.Visible = true;
                }
                cash.Text = personal.cash.ToString();
                account_name.Text = personal.name;
                crruncy.Text = personal.crruncy;
                arabic_cash.Text = new model.ToWord(personal.cash, personal.crruncy).ConvertToArabic();

                this.AutoScroll = true;
                this.Size = new Size(570, 504);
            }
        }
        void refreshVisa(bool condation)
        {
            if (condation)
            {
                cardPreview.Visible = true;
                notHaveVisa.Visible = false;

                cardNumber.Text = personal.accountVisa.visaNumber;
                cardExpDate.Text = personal.accountVisa.expDate;
                cardOwnerName.Text = personal.accountVisa.nameInVisa;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personal.accountVisa = viewmodel.createCard.getNewVisa();
            refreshVisa(personal.accountVisa != null);
            if (personal.accountVisa != null)
            {
               if( db.personalAccountDB.createNewVisaByID(personal.accountNumber, personal.accountVisa))
                {
                    MessageBox.Show("تم حفظ بيانات البطاقة بنجاح");
                }
            }

           
        }
    }
}
