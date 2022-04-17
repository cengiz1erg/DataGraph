using AutoMapper;
using CurrencyProvider.Entity;
using CurrencyProvider.Model;
using ProvisionSecond.Core.Dto;
using ProvisionSecond.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionSecond.Business.MapperProfiles
{
    public class CurrencyProfile: Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyPro, Currency>().ReverseMap();
            CreateMap<CurrencyPro, CurrencyGraph>().ReverseMap();
        }
    }
}
