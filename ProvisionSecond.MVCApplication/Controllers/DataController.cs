using AutoMapper;
using CurrencyProvider.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvisionSecond.Business.Repository;
using ProvisionSecond.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvisionSecond.Core.Entities;
using System.Net;

namespace ProvisionSecond.MVCApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DataController : Controller
    {
        //private readonly MyContext _mycontext;
        private readonly CurrencyRepo _currencyRepo;
        private readonly IMapper _mapper;

        public DataController(CurrencyRepo currencyRepo, IMapper mapper)
        {
            //_mycontext = myContext;
            _currencyRepo = currencyRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Save()
        {
            int number = _currencyRepo.CountOfRows();
            if (number != 0)
            {
                _currencyRepo.DeleteAllRows();
            }
            var service = new CurrencyService();
            
            DateTime now = DateTime.UtcNow;
            DateTime olddate = new DateTime(now.Year, now.Month - 2, now.Day);
            for (DateTime date = olddate; now.CompareTo(date) > 0; date = date.AddDays(1.0))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                var Response = service.GetCurrencyRates(date);
                foreach (var Currency in Response)
                {
                    var model = _mapper.Map<CurrencyPro>(Currency);
                    model.DateTime = date;
                    _currencyRepo.Insert(model);
                }
            }
            return Redirect("/Currency/Index");
        }
    }
}
