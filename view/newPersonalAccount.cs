using System;
using System.Drawing;

namespace Bank_System.view
{
    public partial class newPersonalAccount : model.FormWithPlugins
    {
        public newPersonalAccount()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            model.personalAccount account = new model.personalAccount();

            account.name = fullName.Text;
            account.accountNumber = model.RandomNumbers.accountNumberGen();
            account.national = national.Text;
            account.nationalId = nationalID.Text;
            account.crruncy = crruncy.Text;
            account.isHaveCheque = chequeCheck.Checked;
            account.isHaveVisa = visaCheck.Checked;
            account.job = job.Text;
            account.cash = double.Parse(cash.Text);

            account.accountReport = accountReport.Text;
            account.nationalIdPhoto = model.photo.encryption(nationalID_FileDialog.FileName);
            account.tradeReportPhoto = model.photo.encryption(tradeReport_FileDialog.FileName);
            account.notes = richNote.Text;
            if (account.isHaveVisa)
            {
                if (account.accountVisa == null)
                {
                    account.accountVisa = viewmodel.createCard.getNewVisa();
                }


            }
            if (account.accountVisa != null)
            {
                model.systemData.navigator.formStore.Push(this);
                viewmodel.customUserAccountPreview custom = new viewmodel.customUserAccountPreview(account);
                this.Visible = false;
                custom.ShowDialog();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            nationalID_FileDialog.ShowDialog();
            if (nationalID_FileDialog.FileName != "")
            {

                idPath.Text = nationalID_FileDialog.FileName;



            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (nationalID_FileDialog.FileName != "")
            {

                Bitmap bitmap = new Bitmap(nationalID_FileDialog.FileName);
                viewmodel.previewIMGDialog preview = new viewmodel.previewIMGDialog(nationalID_FileDialog.FileName, bitmap);
                preview.ShowDialog();
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            tradeReport_FileDialog.ShowDialog();
            if (tradeReport_FileDialog.FileName != "")
            {
                tradeReportPath.Text = tradeReport_FileDialog.FileName;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (tradeReport_FileDialog.FileName != "")
            {

                Bitmap bitmap = new Bitmap(tradeReport_FileDialog.FileName);
                Bank_System.viewmodel.previewIMGDialog preview = new viewmodel.previewIMGDialog(tradeReport_FileDialog.FileName, bitmap);
                preview.ShowDialog();
            }
        }

        private void newPersonalAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
