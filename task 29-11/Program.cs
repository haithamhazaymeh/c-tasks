using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _29_11_2022_Tasks
{
    class Employees
    {
        protected string name;
        protected DateTime birth;
        protected int ID;

        public Employees() { }
        public Employees(string name, DateTime birth, int iD)
        {
            this.name = name;
            this.birth = birth;
            ID = iD;
        }

        public virtual void YourAge()
        {
            int x = Convert.ToInt32(DateTime.Now.Year);
            int b = Convert.ToInt32(birth.Year);
            int y = x - b;
            int m1 = Convert.ToInt32(((DateTime.Now - birth).TotalDays % 365.242199) / 30) - 1;
            int d1 = Convert.ToInt32(((DateTime.Now - birth).TotalDays % 365.242199) % 30) - 2;
            Console.WriteLine("Your Age = " + y + " Years " + m1 + " Months " + d1 + " Days ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Wellcome " + name + " Employee With ID = " + ID);
            Console.WriteLine("Your Birth-Date :  " + birth + " Year ");
            Console.Write("And ");
            YourAge();

        }
    }
    class Manager : Employees
    {
        public Manager(string name, DateTime birth, int iD) : base(name, birth, iD) { }

        public override void YourAge()
        {
            base.YourAge();
            Console.WriteLine("MANAGER .....");

        }
        public override void Print()
        {
            Console.WriteLine("Wellcome " + name + " MANAGER  With ID = " + ID);
            Console.WriteLine("Your Birth-Date :  " + birth + " Year M");
            Console.Write("And, ");
            YourAge();

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1998, 06, 09);
            Employees e = new Employees("haitham", birthday, 111111);
            e.Print();
            Console.WriteLine("---------------------------");
            DateTime birthday2 = new DateTime(1996, 09, 03);
            Employees m = new Manager("khaled", birthday2, 11246);
            m.Print();

            DateTime birthday3 = Convert.ToDateTime(Console.ReadLine());
            Employees m1 = new Manager("ali", birthday3, 1316413);
            m1.Print();
        }
    }
}