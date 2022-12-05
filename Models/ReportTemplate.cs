using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Models
{
    public class ReportTemplate
    {
        [Key]
        [Display(Name = "Код шаблона")]
        public string Code { get; set; }

        [Display(Name = "Название")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Тип отчета")]
        public int TypeId { get; set; }

        [Display(Name = "Класс")]
        public string Classname { get; set; }
    }
}
