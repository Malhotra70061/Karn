using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karn.Context;
using Karn.Modals;
using Microsoft.EntityFrameworkCore;

namespace Karn.Service
{
    public class BasicTaxCalculationService : IBasicTaxCalculationService
    {
        private readonly ApplicationDBContext _Db;
        public BasicTaxCalculationService(ApplicationDBContext Db)
        {
            _Db = Db;
        }
        public async Task<IEnumerable<BasicDataTable>> GetAsync()
        {
            try
            {
                var AllData = await _Db.BasicTaxCalculation.ToListAsync();
                var datalist = new List<BasicDataTable>();

                foreach (var item in AllData)
                {
                    var basicDataTable = new BasicDataTable
                    {
                        NameOfPerson = item?.NameOfPerson ?? "N/A", 
                        DOB = item?.DOB ?? DateTime.MinValue,    
                        NetTaxableIncome = item?.NetTaxableIncome ?? 0,  
                        SuperSeniorCitizen = item?.SuperSeniorCitizen ?? "NO",  
                        BasicTaxPayable = item?.BasicTaxPayable ?? 0  
                    };


                    datalist.Add(basicDataTable);
                }

                return datalist;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<BasicTaxCalculation> PostAsync(BasicTaxCalculation basicTaxCalculation)
        {
            await _Db.AddAsync(basicTaxCalculation);
            _Db.SaveChanges();
            return basicTaxCalculation;
        }
    }
}
