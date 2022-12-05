using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Models
{
    public class ReportType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Название")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}
