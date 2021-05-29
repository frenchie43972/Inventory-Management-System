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
            Inventory.AllParts.Add(new InHouse("Hooskerdoo", 25, 12, 1, 1, 001));
            Inventory.AllParts.Add(new InHouse("Hooskerdont", 13, 7, 2, 1, 010));
            Inventory.AllParts.Add(new Outsource("Flimflamery", 25, 3, 5, 1, "ABC Stores"));
            Inventory.AllParts.Add(new Outsource("Wonka Bar", 25, 3, 5, 1, "CCF Inc."));
            Application.Run(new MainForm());
        }
    }
}
