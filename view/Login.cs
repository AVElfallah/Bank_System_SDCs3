using System.Windows.Forms;


namespace Bank_System.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, System.EventArgs e)
        {
            mainScreen mainScreen = new mainScreen();
            mainScreen.Show();
            this.Hide();

        }
        bool passwordIsShown = false;
        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            if (passwordIsShown)
            {
                passWord.PasswordChar = '*';
            }
            else
            {
                passWord.PasswordChar = '\0';
            }

            passwordIsShown = !passwordIsShown;

        }
    }
}
