using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotnet_Prac
{
    public delegate void DelegateGreeting();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<< LINQ>>>>>>>>>>>>");
            LINQ();
            Console.WriteLine("<<<<<<<<<<< delegate>>>>>>>>>>>>");
            DelegateGreeting delegateGreeting = new DelegateGreeting(SUP);
            delegateGreeting.Invoke();
            Console.WriteLine("<<<<<<<<<<< implemented properties>>>>>>>>>>>>");
            Student student = new Student(age: 18, isMale: true, name: "John");
            Console.WriteLine(student.name +" "+ student.age);
            student.age = 22;
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

    //Automatic implementated properties
    class Student
    {
        public string name { get; }

        public int age { get; set; }

        public bool isMale { get; }

        public Student(string name, int age, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.isMale = isMale;
        }
    }

    

}
