using System;

namespace Bank_System.model
{
    public class calcLoanEndDate
    {
        public static DateTime endDate(string installmentSystem, int installmentsNumber)
        {

            var now = DateTime.Now;
            int increasingVal;

            switch (installmentSystem)
            {
                case "شهري":
                    increasingVal = 1;

                    break;
                case "ربع سنوي (كل ثلاثة شهور)":
                    increasingVal = 3;

                    break;
                case "سنوي (كل سنة)":
                    increasingVal = 12;
                    break;
                case "نصف سنوي (كل 6 شهور)":
                    increasingVal = 6;
                    break;
                default:
                    increasingVal = 0;
                    break;
            }

            now = now.AddMonths(increasingVal * installmentsNumber);
            return now;
        }
        public static String endDateString(string installmentSystem, int installmentsNumber)
        {

            var now = endDate(installmentSystem, installmentsNumber);
            string backStr = $"ينقضي في عام {now.Year} في شهر {now.Month} ";


            return backStr;
        }
        public static String endDateString(DateTime endDate)
        {


            string backStr = $"ينقضي في عام {endDate.Year} في شهر {endDate.Month} ";


            return backStr;
        }
    }
}
