using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Karn.Modals
{ 
    public class Calculation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Salary Income is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Salary Income must be a non-negative number")]
        public int SalaryIncome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Other Source Income must be a non-negative number")]
        public int OtherSourceIncome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Deduction must be a non-negative number")]
        public int Deduction { get; set; }


        public int? TotalIncome { get; set; }
        public int? NetTaxableIncome { get; set; }
    }
}
