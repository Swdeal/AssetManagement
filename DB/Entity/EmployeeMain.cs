using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entity
{
    [Table("EMPLOYEE")]
    public class EmployeeMain
    {
        [Key]
        [Required]
        [MaxLength(36)]
        [Column(TypeName = "VARCHAR(36)")]
        public string? EmployeeUID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "VARCHAR(10)")]
        public string? EmployeeID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "VARCHAR(10)")]
        public string? EmployeePWD { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "NVARCHAR(10)")]
        public string? EmployeeName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "VARCHAR(50)")]
        public string? EmployeeEmail { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "VARCHAR(8)")]
        public string? CreateUser { get; set; }

        public DateTimeOffset CreateTime { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "VARCHAR(8)")]
        public string? ModifyUser { get; set; }

        public DateTimeOffset ModifyTime { get; set; }
    }
}
