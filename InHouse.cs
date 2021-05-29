using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFrench_C968
{
    class InHouse : Part 
    {
        public int MachineID { get; set; }

        public InHouse (string Name, decimal Price, int InStock, int Min, int Max, int machineID ) : base( Name,  Price,  InStock,  Min,  Max)
        {
            MachineID = machineID;
        }

    }
}
