using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.db
{
    public static class companyLoanDB
    {
        public static bool addNormalLoan(model.LoanClasses.companyWithAccountInOurBankLoan company)
        {
            var con=createConnection.openConnection();
           var now =DateTime.Now;   
            var qu = "insert into company_loan(is_bank_customer,number_in_bank,loan_number,loan_value,benfit_precentage," +
                "installments_number,installment_value,installment_system,loan_end_date," +
                "loan_create_date,field_preview_image,field_preview_note) values(" +
                $"{1},N'{company.companyAccount.accountNumber}',N'{company.loanID}'" +
                $",{company.loanValue},{company.benfitPrecent},{company.installmentsNumber}" +
                $",{company.installmentValue},N'{company.installmentsSystem}','{company.loanEndDate}'" +
                $",'{now}',@photo,N'{company.fieldPreviewNote}')";
            var cmd = new SqlCommand(qu, con);
            cmd.Parameters.AddWithValue("photo",company.fieldPreviewImage);
        
           if (cmd.ExecuteNonQuery() != 0)
            {
                con.Close();
                cmd.Dispose();
                return true;
            }
            con.Close();
            cmd.Dispose();
            return false;
        }
    }
}




