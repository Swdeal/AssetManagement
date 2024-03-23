using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Models.Employee
{
    public class EmployeeViewModel
    {

        /// <summary>
        /// GUID
        /// </summary>
        public string? EmployeeUID { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        [Required]
        public string? EmployeeID { get; set; }

        /// <summary>
        /// 員工密碼
        /// </summary>
        [Required]
        public string? EmployeePWD { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        [Required]
        public string? EmployeeName { get; set; }

        /// <summary>
        /// 員工信箱
        /// </summary>
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$")]
        public string? EmployeeEmail { get; set; }
    }
}
