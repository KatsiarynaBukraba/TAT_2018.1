using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_6.Commands
{
    class CountTypes : ICommand
    {
        public void Execute(List<Product> productList)
        {
            List<string> uniqueProductList = new List<string>();

            foreach (var a in productList)
            {
                uniqueProductList.Add(a.Type);
            }

            Console.WriteLine("\nCountTypes: " + uniqueProductList.Distinct().Count());
        }
    }
}
