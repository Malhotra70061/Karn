using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karn.Modals
{ 

    public class BasicDataTable
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name of person is required and cannot exceed 250 characters.")]
        [StringLength(250, ErrorMessage = "Name of person cannot exceed 250 characters.")]
        public string NameOfPerson { get; set; }

        [Required(ErrorMessage = "Super Senior Citizen status is required.")] 
        public string SuperSeniorCitizen { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")] 
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Net Taxable Income is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Net Taxable Income must be a positive number.")]
        public int NetTaxableIncome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Basic Tax Payable must be a positive number.")]
        public int BasicTaxPayable { get; set; }
         
    }
}
