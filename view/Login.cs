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
            bool isValid = new db.systemLogin().login(userName.Text, password.Text);
            var data = new db.systemLogin().loginAndBackData(userName.Text, password.Text);
            if (isValid)
            {
                model.systemData.adminInfo.adminName = data[0];
                model.systemData.adminInfo.adminRole = data[1];
                mainScreen mainScreen = new mainScreen();
                mainScreen.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("هذا الحساب غير موجود بالنظام", "خطأ اثناء التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool passwordIsShown = false;
        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            if (passwordIsShown)
            {
                password.PasswordChar = '*';
            }
            else
            {
                password.PasswordChar = '\0';
            }

            passwordIsShown = !passwordIsShown;

        }
    }
}
