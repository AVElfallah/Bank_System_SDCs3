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

        private int insSystem = 0;
        public int getINTInsSystem { get { return insSystem; } }
        public void setINTInsSystem(string system)
        {
            switch (system)
            {
                case "شهري":
                    insSystem = 1;

                    break;
                case "ربع سنوي (كل ثلاثة شهور)":
                    insSystem = 3;

                    break;
                case "سنوي (كل سنة)":
                    insSystem = 12;
                    break;
                case "نصف سنوي (كل 6 شهور)":
                    insSystem = 6;
                    break;
                default:
                    insSystem = 0;
                    break;
            }

        }

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

        //تفاصيل وملاحظات المعاينة الميدانية
        public String fieldPreviewNote { get; set; }




    }
}
