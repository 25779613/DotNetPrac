using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotnet_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
           // nullable values
            int? x = null;
            Console.WriteLine(x.ToString());
            Console.WriteLine("<<<<<<<<<<< LINQ>>>>>>>>>>>>");
            LINQ();
            Console.WriteLine("<<<<<<<<<<< delegate>>>>>>>>>>>>");
            DelegateGreeting delegateGreeting = new DelegateGreeting(SUP);
            delegateGreeting.Invoke();


        }
        public static void LINQ()
        {
            int[] values = { 100,200,500,600,700,800,10000 };
            IEnumerable<int> enumerable = from value in values where value > 600 select value;        
            foreach(int element in enumerable)
            {
                Console.WriteLine(element);
            }

        }

        public static void SUP()
        {
            Console.WriteLine("hello");
        }
    }

    public delegate void DelegateGreeting();

}
