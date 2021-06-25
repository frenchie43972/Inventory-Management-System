using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFrench_C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public static int productIDCount = 1;

        public Product(string name, decimal price, int stock, int min, int max)
        {
            ProductID = productIDCount++;
            Name = name;
            Price = price;
            Instock = stock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int removePart)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == removePart)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }

            }
            return false;
        }

        //public Part LookupAssociatedPart(int )
        //{

        //}
    }
}
