using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFrench_C968
{
    class Product
    {
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //public void AddAssociatedPart(Part )
        //{

        //}

        //public bool RemoveAssociatedPart(int )
        //{

        //}

        //public Part LookupAssociatedPart(int )
        //{

        //}
    }
}
