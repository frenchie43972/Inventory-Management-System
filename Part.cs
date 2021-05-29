using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFrench_C968
{
    public abstract class Part
    {

        public int PartID { get; set; }        
        public string Name { get; set; }        
        public decimal Price { get; set; }        
        public int InStock { get; set; }        
        public int Min { get; set; }        
        public int Max { get; set; }
        public static int partIDCount = 1;

        public Part(string name, decimal price, int stock, int min, int max)
        {
            PartID = partIDCount++;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }
        
    }
}
