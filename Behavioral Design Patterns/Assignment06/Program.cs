using System;
using Assignment06.Strategy_Design_Pattern;
using Assignment06.State_Design_Pattern;
using Assignment06.TemplateDesignPattern;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hamed Tara - n01540404");
            Console.WriteLine("------------------------\n");

            int choice = 0;

            do
            {
                Console.WriteLine("Please choose a design pattern:");
                Console.WriteLine("1. State Design Pattern");
                Console.WriteLine("2. Template Design Pattern");
                Console.WriteLine("3. Strategy Design Pattern");
                Console.WriteLine("4. Exit");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nExecuting State Design Pattern:");
                            Console.WriteLine("------------------------");

                            Machine machine = new Machine();
                            machine.displayMachineState();
                            machine.setPrevState();
                            machine.setNextState();
                            machine.displayMachineState();

                            Console.WriteLine("------------------------");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("\nExecuting Template Design Pattern:");
                            Console.WriteLine("------------------------");

                            Manufactur b1 = new Car();
                            b1.ManufactureProduct();
                            Manufactur b2 = new Truck();
                            b2.ManufactureProduct();

                            Console.WriteLine("------------------------");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("\nExecuting Strategy Design Pattern:");
                            Console.WriteLine("------------------------");

                            Assignment06.Strategy_Design_Pattern.Directory dir = new Assignment06.Strategy_Design_Pattern.Directory();
                            dir.AddItem(new Item("hamed", 1));
                            dir.AddItem(new Item("tara", 2));

                            dir.Sort(new Bubble("BubbleSort", 1));
                            dir.Sort(new Quick("Quick Sort ", 2));

                            Console.WriteLine("------------------------");
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("Thanks for taught us , Best regards , Hamed ");
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (choice != 4);
        }
    }
}
