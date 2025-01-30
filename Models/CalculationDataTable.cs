using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Karn.Modals
{
    public class CalculationDataTable
    {

        public int Id { get; set; }
        public int SalaryIncome { get; set; }
        public int OtherSourceIncome { get; set; }
        public int Deduction { get; set; }
        public int TotalIncome { get; set; }
        public int NetTaxableIncome  { get; set; }

    }
}
