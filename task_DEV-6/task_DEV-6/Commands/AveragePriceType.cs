using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_6.Commands
{
    class AveragePriceType : ICommand
    {
        private string type;

        public AveragePriceType(string type)
        {
            this.type = type;
        }

        public void Execute(List<Product> productList)
        {
            var typeProductList = productList.Where(product => product.Type == type);
            var priceList = new List<float>();

            foreach (var a in typeProductList)
            {
                priceList.Add(a.CostPerUnit);
            }

            Console.WriteLine("\nAveragePriceType: " + (float)priceList.Average());
        }
    }
}
