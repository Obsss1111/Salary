using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Models
{
    public class Firm
    {
        [Key]
        [Display(Name = "Code of organization")]
        [DataType(DataType.Text)]
        public int Code { get; set; }

        [Display(Name = "Name of organization")]
        [DataType(DataType.Text)]
        public string ShortName { get; set; }

        [Display(Name = "Full name of organization")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }
    }
}
