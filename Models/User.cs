using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salary.Models
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public int UserId { get; set; }
    }    
}
