using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotnet_Prac
{
    public delegate void DelegateGreeting();

   // public delegate List<Employee> DelegateEmployees();
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
            Console.WriteLine(student.name + " " + student.age);

            Console.WriteLine("<<<<<<<<<<< Implicit typing>>>>>>>>>>>>");
            ImplicitTyping();

            Console.WriteLine("<<<<<<<<<<<Lambda Expressions>>>>>>>>>>>>");
            LambdaExpressions();

            Console.WriteLine("<<<<<<<<<<<Anon DataType>>>>>>>>>>>>");
            AnonDataTypes();
        }

        //Queries
        public static void LINQ()
        {
            int[] values = { 100,200,500,600,700,800,10000 };
            IEnumerable<int> enumerable = from value in values where value > 600 orderby value descending select value;        
            foreach(int element in enumerable)
            {
                Console.WriteLine(element);
            }

        }

        //delegated method
        public static void SUP()
        {
            Console.WriteLine("hello");
        }

        // Implicit typing
        static void ImplicitTyping()
        {
            //with vars use dynamic in foreachs
            var scores = new[] { 1, 2, 30, 2.5, 60, 10, 22, 3.6 };
            foreach (dynamic score in scores)
            {
                Console.WriteLine(score);
                
            }
           // IEnumerable<dynamic> LINQMEBABYONEMORETIME = from score in scores where scores < 12 select score;
        }

        //Lambda expression
        static void LambdaExpressions()
        {
            // DelegateEmployees delegateEmployees = new DelegateEmployees(GetEmployees);
            // List<Employee> employees = delegateEmployees.Invoke();
            List<Employee> employees = GetEmployees();
            List<Employee> highwage = employees.FindAll(x => x.wage > 2400);
            foreach (Employee element in highwage)
            {
                Console.WriteLine(element.empName +":"+element.wage);
            }
        } 
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee> {
                 new Employee { empName = "james", wage = 2200 },
                 new Employee { empName = "kanye", wage = 2500 },
                 new Employee { empName = "el", wage = 2650 },
                 new Employee { empName = "borenes", wage = 2700 },
                 new Employee { empName = "elton", wage = 2000 }

        };
            return employees;
        }

        // Anon datatypes

        static void AnonDataTypes()
        {
            var person = new
            {
                firstName ="james",
                lastName ="barns",
                nationality ="sa",
                age = 16
            };

            Console.WriteLine(person.firstName +":" + person.age + ":" + person.nationality);
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

    class Employee
    {
        public string empName;
        public double wage;

        public Employee()
        { }
        public Employee(string empName)
        {
            this.empName = empName;

        }
    }
    

}
