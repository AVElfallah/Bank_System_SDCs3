namespace Bank_System.model.LoanClasses
{
    public class personalLoan : loanBase
    {
        //البيانات الشخصية || البنكية للحساب
        public personalAccount personal { get; set; }

        // صورة التقرير الاتماني
        public byte[] bankAccountReportPhoto { get; set; }
        // صورة ايصال المرفق
        public byte[] elcReceiptPhoto { get; set; }
        //صورة شهادة تحويل المرتب
        public byte[] salaryTransferPhoto { get; set; }
        //للتأكد من انه عميل حالي للبنك
        private bool isCrruntBankUser = false;
        public bool ISCBankUser
        {
            get { return isCrruntBankUser; }
            set { isCrruntBankUser = value; }

        }



    }
}
