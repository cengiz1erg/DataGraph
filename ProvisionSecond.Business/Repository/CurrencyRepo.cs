using ProvisionSecond.Business.Repository.Abstracts;
using ProvisionSecond.Core.Entities;
using ProvisionSecond.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionSecond.Business.Repository
{
    public class CurrencyRepo: BaseRepository<CurrencyPro, Guid>
    {
        public CurrencyRepo(MyContext context) : base(context)
        {
        }

        public int DeleteAllRows()
        {
            var all = from c in Context.Currencies select c;
            Context.Currencies.RemoveRange(all);
            return Context.SaveChanges();
        }

        public int CountOfRows()
        {
            return Context.Currencies.Count();
        }

        public List<string> GetDistinctCurrencies()
        {
            var Currencies = Context.Currencies
                    .Select(CurrencyPro => CurrencyPro.Code)
                    .Distinct()
                    .ToList();
            return Currencies;
        }


    }
}
