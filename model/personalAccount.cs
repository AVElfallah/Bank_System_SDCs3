using System;

namespace Bank_System.model
{
    public class personalAccount
    {
        public string
             accountNumber,
             name,
             national,
             nationalId,

             job,


             crruncy,
             accountReport,
             notes;
        public byte[] nationalIdPhoto
        {
            get;
            set;
        }
        public byte[] tradeReportPhoto
        {
            get;
            set;
        }
        public double cash;
        public bool isHaveVisa, isHaveCheque;
        public Visa accountVisa;
        public DateTime date;


    }
    public class Visa
    {
        public string visaNumber, expDate, nameInVisa;
    }
}
