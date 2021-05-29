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
        //public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static int CurrentIndex { get; set; }

        //public static void AddProduct(Product )
        //{

        //}

        //public static bool RemoveProduct(int )
        //{

        //}

        //public static Product LookupProduct(int )
        //{

        //}

        //public static void UpdateProduct(int , Product )
        //{

        //}

        /*-------------The Parts Section-------------*/


        public static void AddPart(Part newPart)
        {
            AllParts.Add(newPart);
        }

        //public static bool DeletePart(Part )
        //{

        //}

        //public static Part LookupPart(int )
        //{

        //}

        //public static void UpdatePart(int , Part )
        //{

        //}
    }
}
