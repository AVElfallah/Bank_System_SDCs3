namespace Bank_System.model
{
    public class personalAccount
    {
        public string
             accountNumber,
             name,
             national,
             nationalId,
             nationalIdPhotoPath,
             job,
             tradeReportPhotoPath,

             crruncy,
             accountReport,
             notes;

        public double cash;
        public bool isHaveVisa, isHaveCheque;
        public Visa accountVisa;


    }
    public class Visa
    {
        public string visaNumber, expDate, nameInVisa;
    }
}
