using System;

namespace Bank_System.model
{
    public class installment
    {
        public string loan_id { get; set; }
        public DateTime installment_id_this_period { get; set; }
        public DateTime installment_id_next_period { get; set; }
        public double installment_value_with_benfit { get; set; }
    }
}
