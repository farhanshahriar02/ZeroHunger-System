using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string ContactNo { get; set; } = null!;

        public string Address { get; set; } = null!;
    }
}
