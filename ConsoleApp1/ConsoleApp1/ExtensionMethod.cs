using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    public static class ExtensionMethod
    {
        //public static void Factorial(this int num, int num2)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result = result * i;
        //    }

        //    Console.WriteLine(result);
        //}


        public static void GetInfo(this User user)
        {
            Console.WriteLine(user.Name);
        }
    }
}
