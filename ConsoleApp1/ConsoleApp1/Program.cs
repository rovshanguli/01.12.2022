using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num = 5;
            //num.Factorial(10);

            //User user = new User() { Name = "Ayan" };
            //user.GetInfo();
            GetEnamValues();

        }



        static void GetEnamValues()
        {
            foreach (var item in Enum.GetValues(typeof(Names)))
            {
                Console.WriteLine(item);
            }
        }


        public enum Names
        {
            Ayaz,
            Rasim,
            Huseyin
        }














    }
}
