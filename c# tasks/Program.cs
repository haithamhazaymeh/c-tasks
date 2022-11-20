using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1 

            string name =  "Haitham" ;
            name =Console.ReadLine();
            Console.WriteLine(name);

            //task 2 

            string[] thename = { "haitham", "ali", "khaled" };
            Console.WriteLine(thename[1]);

            bool[] boolex = { true, false };
            Console.WriteLine(boolex[0]);

            int[] number = { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine(number[3]);

            char[] chars = {'a','b','c'};
            Console.WriteLine(chars[1]);

            double[] num = { 1.5, 2.5, 3.5 };
            Console.WriteLine(num[1]);

            //task3

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars.Length);

            //task4

            string firstname = "";
            firstname= Console.ReadLine();
            string lastname = "";
            lastname= Console.ReadLine();

            int year_birth =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine(firstname+ lastname+year_birth);

            //Task 5
            int[] numbers = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);



            //Task6


            int[] elements = { 1, 2, 3, };
            int sum;
            sum = elements[0] + elements[1] + elements[2];
            Console.WriteLine("Sum = " + sum);


        }
    }
}
