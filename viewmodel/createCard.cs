using System;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class createCard : Form
    {
        public bool isnewVisa = false;
        private static model.Visa visa;

        public createCard()
        {
            InitializeComponent();
            visa = new model.Visa();
        }
        public static model.Visa getNewVisa()
        {
            var dailog = new createCard();
            dailog.isnewVisa = true;
            dailog.ShowDialog();
            if (dailog.textBox1.Text != "" && dailog.textBox2.Text != "" && dailog.textBox3.Text != "")
                return visa;
            return null;
        }



        private void createCard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cardOwnerName.Text = textBox1.Text;
            visa.nameInVisa = cardOwnerName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardNumber.Text = model.RandomNumbers.randomCardNumber();
            textBox3.Text = cardNumber.Text;
            visa.visaNumber = cardNumber.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cardExpDate.Text = "Exp: " + textBox2.Text;
            visa.expDate = cardExpDate.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
