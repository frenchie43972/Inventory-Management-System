using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFrench_C968
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static int PartIndexSelect = -1;
        public static int CurrentIndex { get; set; }
        public static Part CurrentPart { get; set; }
        public static Product CurrentProduct { get; set; }

        /*-------------------Product section-------------------*/
        public static void Add_Product(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool RemoveProduct(int deleteProduct)
        {
            foreach (var product in Products)
            {
                if (deleteProduct == product.ProductID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        //public static Product LookupProduct(int )
        //{

        //}

        public static void UpdateProduct(int productID, Product modProduct)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    product.Name = modProduct.Name;
                    product.Price = modProduct.Price;
                    product.Instock = modProduct.Instock;
                    product.Min = modProduct.Min;
                    product.Max = modProduct.Max;
                    return;
                }
            }
        }

        /*-------------The Parts Section-------------*/


        public static void AddPart(Part newPart)
        {
            AllParts.Add(newPart);
        }

        public static bool DeletePart(Part deletePart)
        {
            AllParts.Remove(deletePart);
            return true;
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public static void UpdatePart(int partID, Part modPart)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == partID)
                {
                    part.Name = modPart.Name;
                    part.Price = modPart.Price;
                    part.InStock = modPart.InStock;
                    part.Min = modPart.Min;
                    part.Max = modPart.Max;
                    return;
                }
            }
        }
    }
}
