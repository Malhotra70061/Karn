using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace Karn.Modals
{
    public class BasicTaxCalculation
    {
        public int Id { get; set; }

        [StringLength(250, ErrorMessage = "Name of person cannot exceed 250 characters.")]
        public string NameOfPerson { get; set; }
        public string SuperSeniorCitizen { get; set; }
        public DateTime? DOB { get; set; }
        public int? NetTaxableIncome { get; set; }
        public int? BasicTaxPayable { get; set; }
         
    }
}
