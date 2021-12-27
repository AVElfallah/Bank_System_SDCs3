using System;
using System.Linq;
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
            var now = DateTime.Now;
            var xyear = now.Year;

            var m = Enumerable.Range(1, 12).Cast<object>().ToArray();
            var y = Enumerable.Range(xyear + 1, 30).Cast<object>().ToArray();
            year.Items.AddRange(y);
            month.Items.AddRange(m);
        }
        public static model.Visa getNewVisa()
        {
            var dailog = new createCard();
            dailog.isnewVisa = true;

            dailog.ShowDialog();
            if (dailog.textBox1.Text != "" && dailog.year.Text != "" && dailog.month.Text != "" && dailog.textBox3.Text != "")
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


        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yt = year.Text.Length == 4 ? $"{year.Text[2]}{year.Text[3]}" : "";
            var x = $"ExpDate:{month.Text}/{yt}";

            cardExpDate.Text = x;
            if (month.Text != "" && year.Text != "")
            {
                visa.expDate = cardExpDate.Text;
            }
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yt = year.Text.Length == 4 ? $"{year.Text[2]}{year.Text[3]}" : "";
            var x = $"ExpDate:{month.Text}/{yt}";

            cardExpDate.Text = x;
            if (month.Text != "" && year.Text != "")
            {
                visa.expDate = cardExpDate.Text;
            }
        }
    }
}
