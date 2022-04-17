using ProvisionSecond.Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionSecond.Core.Entities
{
    public class CurrencyPro: BaseEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public double ForexBuying { get; set; }
        public double ForexSelling { get; set; }

        public double BanknoteBuying { get; set; }
        public double BanknoteSelling { get; set; }

        public double CrossRateUsd { get; set; }
        public double CrossRateOther { get; set; }
    }
}
