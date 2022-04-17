using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProvisionSecond.Business.Repository;
using ProvisionSecond.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvisionSecond.MVCApplication.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly CurrencyRepo _currencyRepo;
        private readonly IMapper _mapper;

        public CurrencyController(CurrencyRepo currencyRepo, IMapper mapper)
        {
            _currencyRepo = currencyRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Currencies = _currencyRepo.GetDistinctCurrencies();
            ViewBag.Currencies = Currencies;
            return View();
        }

        [HttpPost]
        public IActionResult GetCurrencyData(string input)
        {
            var data = _currencyRepo
                .Get(Currency => Currency.Code == input)
                .Select(Currency => _mapper.Map<CurrencyGraph>(Currency))
                .ToList();
            return Ok(data);
        }
    }
}
