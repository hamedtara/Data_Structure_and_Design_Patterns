using Assignment04.AbstractFactory;
using Assignment04.Employee;
using Assignment04.FactoryMethod;
using Assignment04.Singleton;
using System;
using System.Reflection.Metadata;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hamed Tara n01540404");
            Console.WriteLine("Hi ,Welcome to Assignment 04");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Menu Options : ");
            Boolean flag = true;
            while(flag) {
             Console.WriteLine("-------------------------------------------------------------------");
            //Demonstrate singleton design pattern for a course class 
             Console.WriteLine("\n1: Test Singleton Design Pattern");
            //2.Prototype: Demonstrate Prototype design pattern for a Employee class that’s has three properties – ID, Name, Address 
            Console.WriteLine("2: Test protptype design pattern ");
            Console.WriteLine("3: Test Factory Method"  );
            Console.WriteLine("4: Test Abstract Factory");
            Console.WriteLine("5: Exit ");


                switch (Console.ReadLine())
                {
                    case "1":
                        Course course1 = Course.getInstance();
                        Course course2 = Course.getInstance();
                        if (course1 == course2)
                        {
                            Console.WriteLine("\nSingleton Works!");
                            Console.WriteLine("The key point of singleton is that we have just a intace of an object ");
                        }

                        else
                        {
                            Console.WriteLine("\nSingleton failed!");
                        }
                        break;
                    case "2":
                        Employee employee1 = new Employee();
                        employee1.Id = 1;
                        employee1.Name = "Hamed";
                        employee1.Address = "RichmondHill";

                        Employee employee2 = (Employee)employee1.getClone();
                        employee2.Name = "Ehsan";
                        employee2.Id = 2;
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine(employee1.Id + ": " + employee1.Name + " " + employee1.Address);
                        Console.WriteLine(employee2.Id + ": " + employee2.Name + " " + employee2.Address);
                        Console.WriteLine("\nAs you can see I created a deep copy of employee 1 to employee 2 ,then I changed Id and name ," +
                            "\nbut I didnot change the address so it  remained without any changes ");
                        break;
                    case "3":

                        Console.WriteLine("-----------------------------------------------");

                        Recipe recipeIceCream = new IceCream();
                        Recipe recipeCofee = new Coffee();

                        Console.WriteLine("-------- Ice Cream --------");
                        foreach (Ingredients ingredients in recipeIceCream.Ingredients)
                        {
                            Console.WriteLine(ingredients.GetType().Name);
                        }

                        Console.WriteLine("-------- Cofee ---------");
                        foreach (Ingredients ingredients in recipeCofee.Ingredients)
                        {
                            Console.WriteLine(ingredients.GetType().Name);
                        }

                       

                        break;

                        case "4":
                        Console.WriteLine("-------------------------------------");
                        Client c1 = new Client(new StoreA());
                        c1.Compare();

                        Client c2 = new Client(new StoreB());
                        c2.Compare();
                        break;

                        case "5":
                        flag = false;
                        break;
                }

            }

        }
    }
}