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

            int num1 = Convert.ToInt16(Console.ReadLine());

            int num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num2);

            }
            else if (num1 < num2)
            {
                Console.WriteLine(num1);


            }
            else { Console.WriteLine("The numbers are equal");
            };


            //task 2

            int num = -7;

            if (num<0) {
                Console.WriteLine("The sign is - ");
                    } else { Console.WriteLine("The sign is +");
            }


            //task 3

            int x = 0;
            int y = -1;
            int z = 4;

            if (y > z && y > x)  {
                if (z > y) {
                    Console.WriteLine(y + "" + z + "" + x);
                } else {
                    Console.WriteLine(y + "" + x + "" + z);


                } } else if (z>y && z>x) {
                
                if (y>x) {
                        Console.WriteLine(z + "" + y + "" + x);

                    } else
                    {
                        Console.WriteLine(z + "" + x + "" + y);
                    }
                
                } else if (x>y || x>z){
                
                    if (y>z) {

                        Console.WriteLine(x + "" + y + "" + z);

                    } else
                    {
                        Console.WriteLine(x + "" + z + "" + y);
                    }

                }

            //task 4 

            int num_1 = 3;
            int num_2 = 6;
            int num_3 = 11;
            int num_4 = 8;
            int num_5 = 9;
            if (num_1 >= num_2 && num_1 >= num_3 && num_1 >= num_4 && num_1 >= num_5)
            {
                Console.WriteLine(num_1);
            }
            else if (num_2 >= num_1 && num_2 >= num_3 && num_2 >= num_4 && num_2 >= num_5)
            {
                Console.WriteLine(num_2);
            }
            else if (num_3 >= num_2 && num_3 >= num_1 && num_3 >= num_4 && num_3 >= num_5)
            {
                Console.WriteLine(num_3);
            }
            else if (num_4 >= num_2 && num_4 >= num_3 && num_4 >= num_1 && num_4 >= num_5)
            {
                Console.WriteLine(num_4);
            }
            else if (num_5 >= num_2 && num_5 >= num_3 && num_5 >= num_4 && num_5 >= num_1)
            {
                Console.WriteLine(num_5);
            }


            //task 5 

            double re = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(re * 0.62137119);

            //Task 6

            int hours = 5;
            int munits = 50;
            Console.WriteLine(hours * 60 + munits);

            //task 7 
            int mun = 546;
            Console.WriteLine(mun / 60 + " "+ mun%60);

            //task 8 

            string[] array1 = { "yazeed", "ashraf", "haitham", "ahmed", "abdalkharem" };

            Console.WriteLine(array1[0].Substring(0, 3));
            Console.WriteLine(array1[1].Substring(0, 3));
            Console.WriteLine(array1[2].Substring(0, 3));
            Console.WriteLine(array1[3].Substring(0, 3));
            Console.WriteLine(array1[4].Substring(0, 3));





        }
    }
}
