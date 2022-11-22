using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tasks22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 

            //int[] ARR = { 1, 7, 9, 45, };
            //string[] arr2 = { "Str", "alex", "moh" };
            //string [] arr3 = {"the","fox" , "over", "lazy", "dog"} ;

            //task 2 

            ////2 - What the index of "Banana","Tomato" ?
            //String[] fruits = { "Tomato", "Banana", "Watermelon" };

            //Tomato[0]     Banana[1]

            //Task 3 

            //string[] sport = { "football", "tenes", "basketball", "Run", "Handball" };
            //string[] foods = { "Mansaf", "Falafel", "Maqluba", "Shawarma", "Mujadara" };
            //string[] country = { "jordan", "Qater", "Egypt", "KSA", "UAE" };

            //foreach (string i in sport)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (string i in foods)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (string i in country)
            //{
            //    Console.WriteLine(i);
            //}

            //task 4

            //string num = Console.ReadLine();
            //string[] num1 = num.Split(',');
            //int sum = 0;

            //for (int i = 0; i < 3; i++)
            //{

            //    sum += Convert.ToInt32(num1[i]);

            //}

            //Console.WriteLine(sum);

            //// task5

            //int numb = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%2 != 0)
            //    {
            //        Console.WriteLine(i);
            //        numb += i;
            //    }

            // }
            //Console.WriteLine(numb);



            //Task6

            //for (int i = 0; i < 5; i++)
            //{


            //    for (int j=4-i;j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }



            //    Console.WriteLine();


            //}

            


            //task 7

        
            int sum = 1;
            for (int i = 0; i < 5; i++)
            {


                for (int j = 4 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(sum + " ");
                    sum++;
                }



                Console.WriteLine();

            }













        }
    }
}
