﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salary.Models
{
    public class Role
    {
        [Display(Name = "Identificator роли")]
        [DataType(DataType.Text)]
        public int Id { get; private set; }

        [Display(Name = "Role")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Rules")]
        public List<Right> Rights { get; private set; }

        public bool AddRight(Right right)
        {
            var contains = Rights.Contains(right);
            if (contains) return false;
            Rights.Add(right);
            return true;
        }

        public bool RemoveRight(Right right)
        {
            return Rights.Remove(right);
        }
    }
}