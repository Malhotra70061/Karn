using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karn.Modals;

namespace Karn.Service
{
    public interface ICalculationService
    {
        Task<IEnumerable<CalculationDataTable>> GetAsync();
        Task<Calculation> PostAsync(Calculation calculation);
    }
}
