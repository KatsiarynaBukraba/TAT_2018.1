using System;
using System.Collections.Generic;
using task_DEV_6.Commands;

namespace task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo continueInput = new ConsoleKeyInfo();

            List<Product> productList = new List<Product>();

            try
            {
                do
                {
                    var product = new ProductBuilder();

                    Console.WriteLine("\nInput type of product:");
                    product.SetType(Console.ReadLine());

                    Console.WriteLine("\nInput the name of product:");
                    product.SetName(Console.ReadLine());

                    Console.WriteLine("\nInput the quantity of product");
                    product.SetQuantity(Console.ReadLine());

                    Console.WriteLine("\nInput the cost of one product");
                    product.SetCostPerUnit(Console.ReadLine());

                    productList.Add(product.Build());

                    continueInputProducts:

                    Console.WriteLine("\nDo you want to continue to input products?");
                    Console.WriteLine("Yes [LeftArrow] | No [RightArrow]");
                    continueInput = Console.ReadKey();

                    if (continueInput.Key != ConsoleKey.RightArrow && continueInput.Key != ConsoleKey.LeftArrow) goto continueInputProducts;
                }
                while (continueInput.Key == ConsoleKey.LeftArrow);

                string number;

                do
                {
                    chooseCommand:

                    Console.WriteLine("\nChoose command:" +
                    "\n1) count types\n" +
                    "2) count all\n" +
                    "3) average price (all types)\n" +
                    "4) average price (type)\n" +
                    "5) exit\n" +
                    "Input number: ");

                    number = Console.ReadLine();

                    Invoker invoker = new Invoker();

                    switch (number)
                    {
                        case "1":
                            invoker.SetCommand(new CountTypes());
                            invoker.ExecuteCommand(productList);
                            break;
                        case "2":
                            invoker.SetCommand(new CountAll());
                            invoker.ExecuteCommand(productList);
                            break;
                        case "3":
                            invoker.SetCommand(new AveragePrice());
                            invoker.ExecuteCommand(productList);
                            break;
                        case "4":
                            Console.WriteLine("Input type: ");
                            string type = Console.ReadLine();
                            invoker.SetCommand(new AveragePriceType(type));
                            invoker.ExecuteCommand(productList);
                            break;
                        case "5":
                            return;
                        default:
                            goto chooseCommand;
                    }
                }
                while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
