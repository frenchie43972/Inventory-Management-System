using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFrench_C968
{
    class Outsource : Part 
    {
        public string CompanyName { get; set; }

        public Outsource(string Name, decimal Price, int InStock, int Min, int Max, string companyName) : base(Name, Price, InStock, Min, Max)
        {
            CompanyName = companyName;
        }
    }
}
