namespace Bank_System.model.LoanClasses
{
    public class companyWithoutAccountLoan : loanBase
    {
        public companyAccount company { get; set; }
        public bool haveBankAccount { get; set; }
        #region ifCompanyHaveAnotherBankAccount
        public string bankAccountReportLast6MonthPath { get; set; }
        public string bankName { get; set; }

        public int bankNumber { get; set; }
        #endregion


    }
}
