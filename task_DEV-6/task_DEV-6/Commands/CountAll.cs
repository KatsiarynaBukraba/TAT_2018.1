using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_6.Commands
{
    class CountAll : ICommand
    {
        public void Execute(List<Product> productList)
        {
             Console.WriteLine("\nCountAll: " + productList.Distinct().Count());
        }
    }
}
