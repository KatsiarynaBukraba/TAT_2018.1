using System;
using System.Collections.Generic;
using System.Linq;


namespace task_DEV_6.Commands
{
    class AveragePrice : ICommand
    {
        public void Execute(List<Product> productList)
        {
            var priceList = new List<float>();

            foreach (var a in productList)
            {
                priceList.Add(a.CostPerUnit);
            }

            Console.WriteLine("\nAveragePrice: " + (float)priceList.Average());
        }
    }
}
