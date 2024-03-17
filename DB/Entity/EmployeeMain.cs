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
        [Column("EMPLOYEE_UID", TypeName = "VARCHAR(36)")]
        public string? EmployeeUID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("EMPLOYEE_ID", TypeName = "VARCHAR(10)")]
        public string? EmployeeID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("EMPLOYEE_PWD", TypeName = "VARCHAR(10)")]
        public string? EmployeePWD { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("EMPLOYEE_NAME", TypeName = "NVARCHAR(10)")]
        public string? EmployeeName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("EMPLOYEE_EMAIL", TypeName = "VARCHAR(50)")]
        public string? EmployeeEmail { get; set; }

        [MaxLength(50)]
        [Column("CREATE_USER", TypeName = "VARCHAR(8)")]
        public string? CreateUser { get; set; }

        [Column("CREATE_TIME", TypeName = "DATETIMEOFFSET(7))")]
        public DateTimeOffset CreateTime { get; set; }

        [MaxLength(50)]
        [Column("MODIFY_USER", TypeName = "VARCHAR(8)")]
        public string? ModifyUser { get; set; }

        [Column("MODIFY_TIME", TypeName = "DATETIMEOFFSET(7))")]
        public DateTimeOffset ModifyTime { get; set; }
    }
}
