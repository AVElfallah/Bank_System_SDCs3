using System;

namespace Bank_System.model
{
    public class companyAccount
    {


        public String
              name,
              accountNumber,
              crruncy,
              accountReport,
              notes
              ;
        public DateTime date;
        public byte[] tradeReportPhoto
        {
            get;
            set;
        }
        public byte[] financialIdPhoto
        {
            get;
            set;

        }
        public double
                cash;
        public bool
                isHaveCheque;

    }
}
