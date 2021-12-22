using System;

namespace Bank_System.model.LoanClasses
{
    public abstract class loanBase
    {
        // رقم القرض
        public string loanID { get; set; }
        //قيمة القرض
        public double loanValue { get; set; }

        // قيمة القرض بإضافة الفائدة
        public double loanValueWithBinfets { get; set; }
        //عدد الاقساط
        public double installmentsNumber { get; set; }
        //قيمة القسط الواحد
        public double installmentValue { get; set; }
        // قيمة القسط بإضافة الفائدة

        public double installmentValueWithBinfets { get; set; }
        //نظام السداد
        public string installmentsSystem { get; set; }
        // النسبة المئوية للفائدة
        public double benfitPrecent { get; set; }
        //تاريخ نهاية القرض
        public DateTime loanEndDate { get; set; }
        // صورة المعاينة الميدانية
        public byte[] fieldPreviewImage
        {
            get;
            set;
        }
        public String Paht { get; set; }
        //تفاصيل وملاحظات المعاينة الميدانية
        public String fieldPreviewNote { get; set; }



    }
}
