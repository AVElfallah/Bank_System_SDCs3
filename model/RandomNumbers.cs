using System;

namespace Bank_System.model
{
    public static class RandomNumbers
    {

        public static String randomCardNumber()
        {
            String back = "";
            String rand(int n) => new Random().Next(1000 + n, 9999).ToString();

            return back + rand(10) + " " + rand(241) + " " + rand(603) + " " + rand(1004);
        }
        public static String accountNumberGen()
        {
            //len =10
            String back = "";
            String rand(int n) => new Random().Next(100 + n, 999).ToString();

            return back + rand(10) + rand(45) + rand(76) + 3.ToString();
        }
    }
}
