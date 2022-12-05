using Microsoft.EntityFrameworkCore;
using Salary.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Salary.Models
{
    public enum Firms
    {
        Corporation,
        Law,
        Workshop
    }

    public class Right
    {
        [Key]
        [Display(Name = "ID права")]
        [DataType(DataType.Text)]
        public int Id { get; private set; }

        [Display(Name = "Название")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Разрешенные коды организаций")]
        public Firms FirmAccess { get; set; }

        public static Right CreateRight()
        {
            return new Right();
        }

        public static bool DeleteRight(int id)
        {
            var service = new DbService();
            var right = service.Right.Single(r => r.Id == id);
            service.Right.Remove(right);
            return !service.Right.Contains(right);
        }
    }
}