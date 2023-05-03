using Assignment05.Adaptor;
using Assignment05.Composite;
using Assignment05.Decorator;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.youtube.com/watch?v=GCraGHx6gso

            Console.WriteLine("Hamed Tara - n01540404");
       

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Decorator Design Pattern");
                Console.WriteLine("2. Composite Design Pattern");
                Console.WriteLine("3. Adaptor Design Pattern");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Decorator Design Pattern:\n");

                        Console.WriteLine("***Audio***");

                        Player audio = new BaseEnhancer(new Audio()) { HeightBoss = 50 };
                        audio.play();

                        Console.WriteLine("***Video***");

                        Player video3 = new BaseEnhancer(new Video()) { HeightBoss = 98 };
                        video3.play();

                        break;
                    case "2":
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Composite Design Pattern:\n");

                        Departmnet sales = new Sales(1, " computer");
                        Departmnet finance = new Finance(2, " chair");

                        HeadDepartment head = new HeadDepartment();
                        head.AddDepartment(sales);
                        head.AddDepartment(finance);

                        head.getdepartmentDetail();

                        break;
                    case "3":
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Adaptor Design Pattern\n");

                        speedApp speed1 = new speedApp(20);
                        Console.WriteLine("speed in miles = " + speed1.getSpeed());
                        speedAppUk speed2 = new speedAppUk(speed1);
                        Console.WriteLine("speed in Km /h = " + speed2.getSpeed());

                        break;
                    case "4":
                        Console.WriteLine("Thanks...");
                        return;

                    default:

                        Console.WriteLine("Invalid input.Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
