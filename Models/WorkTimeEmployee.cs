using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Models
{
    public class WorkTimeEmployee
    {
        [Key]
        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public int Id { get; set; }

        [Display(Name = "ID сотрудника")]
        [DataType(DataType.Text)]
        public int EmployeeId { get; set; }

        [Display(Name = "Дата зарплаты")]
        [DataType(DataType.DateTime)]
        public DateTime DateReceipt { get; set; }

        [Display(Name = "Время работы")]
        [DataType(DataType.Time)]
        public DateTime FactTime { get; set; }

        [Display(Name = "Количество часов в месяце")]
        [DataType(DataType.Time)]
        public DateTime MonthTime { get; set; }

        [Display(Name = "Код организации")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Money { get; set; }
    }
}
