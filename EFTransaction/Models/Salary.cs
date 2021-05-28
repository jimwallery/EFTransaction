using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFTransaction.Models
{
    public class Salary
    {
        //[Key]
        public int SalaryId { get; set; }
        public int EmpID { get; set; }

        //[Column(TypeName = "decimal(18,2")]
        public decimal GrossSalary { get; set; }
    }
}
