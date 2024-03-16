using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Models.DataObject.Employee
{
    public class EmployeeDO
    {
        /// <summary>
        /// GUID
        /// </summary>
        public string? EmployeeUID { get; set; }

        /// <summary>
        /// 員工ID
        /// </summary>
        public string? EmployeeID { get; set; }

        /// <summary>
        /// 員工密碼
        /// </summary>
        public string? EmployeePWD { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string? EmployeeName { get; set; }

        /// <summary>
        /// 員工信箱
        /// </summary>
        public string? EmployeeEmail { get; set; }

        /// <summary>
        /// 建立人員
        /// </summary>
        public string? CreateUser { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 修改人員
        /// </summary>
        public string? ModifyUser { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public DateTimeOffset ModifyTime { get; set; }
    }
}
