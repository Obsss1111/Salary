using System;
using System.ComponentModel.DataAnnotations;

namespace Salary.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "ID сотрудника")]
        [DataType(DataType.Text)]
        public int Id { get; set; }

        [Display(Name = "Код организации")]
        [DataType(DataType.Text)]
        public int Firm { get; set; }

        [Display(Name = "Код подразделения")]
        [DataType(DataType.Text)]
        public int Dep { get; set; }

        [Display(Name = "ФИО")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        [Display(Name = "Пол")]
        [DataType(DataType.Text)]
        public char Gender { get; set; }

        [Display(Name = "Должность")]
        [DataType(DataType.Text)]
        public string Prof { get; set; }

        [Display(Name = "День рождения")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "ID пользователя")]
        [DataType(DataType.Text)]
        public int UserId { get; set; }

        [Display(Name = "Уровень должности")]
        [DataType(DataType.Text)]
        public int Boss { get; set; }       
    }
}
