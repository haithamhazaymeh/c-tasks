using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_inh_tasks
{
    class Car
    {
        protected string make;
        protected int year;
        protected string Type;
        protected double Price;
        protected string model;
        protected string Pallet_No;
        protected string color;
        public Car()
        {
        }
        public Car(string m, int y, string t, double p, string mo, string pall, string c)
        {
            make = m;
            year = y;
            Type = t;
            Price = p;
            model = mo;
            Pallet_No = pall;
            color = c;
        }

        public void START()
        {
            Console.WriteLine("Your Car Has Been Started !!");
        }

        public void Stop()
        {
            Console.WriteLine("Your Car Has Been Stopped !!");
        }

        public int KM(int k = 17, int l = 3)
        {
            return (k * l);
        }

    }

    class ferrari : Car
    {

        public ferrari (string make, int year, string Type, double Price, string model, string Pallet_No, string color) : base(make, year, Type, Price, model, Pallet_No, color)
        {
           
        }
        public void all_info()
        {
            Console.WriteLine("Your Car's Make in : " + make);
            Console.WriteLine("Your Car's from : " + year + " Year");
            Console.WriteLine("Your Car's Type  : " + Type);
            Console.WriteLine("Price The Car : " + Price);
            Console.WriteLine("Your Car's Model : " + model);
            Console.WriteLine("Your Car's Pallet : " + Pallet_No);
            Console.WriteLine("Your Car's Color : " + color);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            ferrari ferrari = new ferrari ("Italia ", 2015, "458", 26000, "458 ", "1254abc", "Red");
            ferrari.START();
            ferrari.all_info();

            Console.WriteLine("Please enter how much Kilometer in one liter");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of Liters you have");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Te number of Kilometer in " + y + " Liter = " + ferrari.KM(x, y));
            ferrari.Stop();
        }
    }
}