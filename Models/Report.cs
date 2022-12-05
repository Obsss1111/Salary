using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Models
{
    public class Report
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        [DataType(DataType.Html)]
        public string Header { get; set; }

        [Display(Name = "Код организации")]
        public int Firm { get; set; }

        [Display(Name = "Код подразделения")]
        public int Dep { get; set; }

        [Display(Name = "Констатирующая часть")]
        [DataType(DataType.Html)]
        public string Content { get; set; }

        [Display(Name = "Дата создания")]
        [DataType(DataType.DateTime)]
        public DateTime DateCreate { get; set; }

        [Display(Name = "Дата регистрации")]
        [DataType(DataType.DateTime)]
        public DateTime DateReg { get; set; }

        [Display(Name = "Код шаблона")]
        public string TemplateCode { get; set; }

        [Display(Name = "Тип отчета")]
        public int Type { get; set; }
    }
}
