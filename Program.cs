using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFrench_C968
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Sample parts and product to display when the application starts*/
            Inventory.AllParts.Add(new InHouse("Hooskerdoo", 25.12m, 12, 5, 22, 001));
            Inventory.AllParts.Add(new InHouse("Hooskerdont", 13.77m, 7, 2, 12, 010));
            Inventory.AllParts.Add(new Outsource("Flimflamery", 25.00m, 3, 2, 15, "ABC Stores"));
            Inventory.AllParts.Add(new Outsource("Wonka Bar", 76.90m, 3, 1, 5, "CCF Inc."));
            Inventory.Products.Add(new Product("Widget", 25.00m, 5, 3, 11));
            Inventory.Products.Add(new Product("Gidget", 54.25m, 12, 3, 12));
            Application.Run(new MainForm());
        }
    }
}
