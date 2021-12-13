using System.Drawing;

namespace Bank_System.view
{
    public partial class newCompanyAccount : model.FormWithPlugins
    {
        public newCompanyAccount()
        {
            InitializeComponent();
        }

        private void chequeCheck_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            model.companyAccount company= new model.companyAccount();
            company.accountNumber=model.RandomNumbers.accountNumberGen();
            company.name = companyName.Text;
            company.isHaveCheque = chequeCheck.Checked;
            company.crruncy = crruncy.Text;
            company.accountReport=accountReport.Text;
            company.cash=double.Parse(cash.Text);
            company.notes=richNote.Text;
            company.financialIdPhotoPath = financialID_FileDialog.FileName;
            company.tradeReportPhotoPath = tradeReport_FileDialog.FileName;

            viewmodel.customCompanyAccountPreview customCompany = new viewmodel.customCompanyAccountPreview(company);
            customCompany.ShowDialog();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            tradeReport_FileDialog.ShowDialog();
            if (tradeReport_FileDialog.FileName != "")
            {
                tradeReportPath.Text = tradeReport_FileDialog.FileName;
            }
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            if (tradeReport_FileDialog.FileName != "")
            {

                Bitmap bitmap = new Bitmap(tradeReport_FileDialog.FileName);
                Bank_System.viewmodel.previewIMGDialog preview = new viewmodel.previewIMGDialog(tradeReport_FileDialog.FileName, bitmap);
                preview.ShowDialog();
            }
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            financialID_FileDialog.ShowDialog();
            if (financialID_FileDialog.FileName != "")
            {
               taxsIdPath.Text = financialID_FileDialog.FileName;
            }
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            if (tradeReport_FileDialog.FileName != "")
            {

                Bitmap bitmap = new Bitmap(financialID_FileDialog.FileName);
                Bank_System.viewmodel.previewIMGDialog preview = new viewmodel.previewIMGDialog(financialID_FileDialog.FileName, bitmap);
                preview.ShowDialog();
            }
        }
    }
}
