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
    public class CalculationService : ICalculationService
    {
        private readonly ApplicationDBContext _Db;
        public CalculationService(ApplicationDBContext Db)
        {
            _Db = Db;
        }



        public async Task<IEnumerable<CalculationDataTable>> GetAsync()
        {
            try
            {
                var data = await _Db.Calculation.ToListAsync();
                var datalist = new List<CalculationDataTable>();

                foreach (var item in data)
                { 
                    if (item == null)
                        continue;
                      
                    var basicDataTable = new CalculationDataTable
                    {
                        SalaryIncome = item.SalaryIncome,
                        OtherSourceIncome = item.OtherSourceIncome,
                        Deduction = item.Deduction,
                        TotalIncome = item.TotalIncome ?? 0,
                        NetTaxableIncome = item.NetTaxableIncome ?? 0,
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



        public async Task<Calculation> PostAsync(Calculation calculation)
        {
            if (calculation.Deduction > 150000)
            {
                calculation.Deduction = 150000;
            }
            
            await _Db.AddAsync(calculation);
            _Db.SaveChanges();
            return calculation;
        }
    }
}
