using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Models
{
    public class UserRoles
    {
        [Key]
        [Display(Name = "ID роли пользователя")]
        [DataType(DataType.Text)]
        public int Id { get; private set; }

        [Required]
        [Display(Name = "ID пользователя")]
        [DataType(DataType.Text)]
        public int Userid { get; private set; }

        [Display(Name = "Роли")]
        [DataType(DataType.Text)]
        public List<Role> Roles { get; private set; }
    }
}
