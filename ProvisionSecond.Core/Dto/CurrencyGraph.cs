using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionSecond.Core.Dto
{
    public class CurrencyGraph
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double ForexBuying { get; set; }
        public DateTime DateTime { get; set; }
    }
}
