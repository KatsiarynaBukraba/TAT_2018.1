using System;

namespace task_DEV_6
{
    public class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public uint Quantity  { get; set; }
        public float CostPerUnit { get; set; }

        public static ProductBuilder CreateBuilder()
        {
            return new ProductBuilder();
        }
    }
}
