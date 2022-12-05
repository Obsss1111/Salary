using Microsoft.AspNetCore.Identity;
using Salary.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salary.Models
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {

    }
}
