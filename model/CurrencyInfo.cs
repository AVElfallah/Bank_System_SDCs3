using System;

namespace Bank_System.model
{
    public class CurrencyInfo
    {
        public enum CurrencyType { EGP, DUS, EUR }

        public CurrencyInfo(CurrencyType c)
        {
            switch (c)
            {
                case CurrencyType.EGP:
                    this.CurrencyID = 0;
                    this.CurrencyCode = "EGP";

                    this.Arabic1CurrencyName = "جنية مصري";
                    this.Arabic2CurrencyName = "اثنين جنية مصري";
                    this.Arabic310CurrencyName = "جنيهات مصرية";
                    this.Arabic1199CurrencyName = "جنية مصري";
                    this.Arabic1CurrencyPartName = "قرش";
                    this.Arabic2CurrencyPartName = "قرشان";
                    this.Arabic310CurrencyPartName = "قروش";
                    this.Arabic1199CurrencyPartName = "قرشاً";
                    this.PartPrecision = 2;
                    break;
                case CurrencyType.DUS:
                    this.CurrencyID = 1;
                    this.CurrencyCode = "DUS";

                    this.Arabic1CurrencyName = "دولار امريكي";
                    this.Arabic2CurrencyName = "دولارين امريكيان";
                    this.Arabic310CurrencyName = "دولارات امريكية";
                    this.Arabic1199CurrencyName = "دولار امريكي";
                    this.Arabic1CurrencyPartName = "سنت";
                    this.Arabic2CurrencyPartName = "سنتان";
                    this.Arabic310CurrencyPartName = "سنتات";
                    this.Arabic1199CurrencyPartName = "سنتاً";
                    this.PartPrecision = 2;
                    break;
                case CurrencyType.EUR:
                    this.CurrencyID = 2;
                    this.CurrencyCode = "EUR";

                    this.Arabic1CurrencyName = "يورو";
                    this.Arabic2CurrencyName = "اثنين يورو";
                    this.Arabic310CurrencyName = "يورو";
                    this.Arabic1199CurrencyName = "يورو";
                    this.Arabic1CurrencyPartName = "سنت";
                    this.Arabic2CurrencyPartName = "سنتان";
                    this.Arabic310CurrencyPartName = "سنتات";
                    this.Arabic1199CurrencyPartName = "سنتاً";
                    this.PartPrecision = 2;
                    break;

                default:

                    this.CurrencyID = 0;
                    this.CurrencyCode = "EGP";

                    this.Arabic1CurrencyName = "جنية مصري";
                    this.Arabic2CurrencyName = "اثنين جنية مصري";
                    this.Arabic310CurrencyName = "جنيهات مصرية";
                    this.Arabic1199CurrencyName = "جنية مصري";
                    this.Arabic1CurrencyPartName = "قرش";
                    this.Arabic2CurrencyPartName = "قرشان";
                    this.Arabic310CurrencyPartName = "قروش";
                    this.Arabic1199CurrencyPartName = "قرشاً";
                    this.PartPrecision = 2;
                    break;



            }


        }




        public int CurrencyID { get; set; }


        public string CurrencyCode { get; set; }





        public string Arabic1CurrencyName { get; set; }


        public string Arabic2CurrencyName { get; set; }


        public string Arabic310CurrencyName { get; set; }


        public string Arabic1199CurrencyName { get; set; }

        public Byte PartPrecision { get; set; }



        public string Arabic1CurrencyPartName { get; set; }

        public string Arabic2CurrencyPartName { get; set; }

        public string Arabic310CurrencyPartName { get; set; }


        public string Arabic1199CurrencyPartName { get; set; }

    }
}
