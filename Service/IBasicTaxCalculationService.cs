using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karn.Modals;

namespace Karn.Service
{
    public interface IBasicTaxCalculationService
    {
        Task<IEnumerable<BasicDataTable>> GetAsync();
        Task<BasicTaxCalculation> PostAsync(BasicTaxCalculation basicTaxCalculation);
    }
}
