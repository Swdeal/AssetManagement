using AssetManagement.Core.Models.BusinessObject.Emploee;
using AssetManagement.Core.Models.DataObject.Employee;
using AssetManagement.Core.Service.Interface;
using Lib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Service.Implement.Employee
{
    public sealed partial class EmployeeService : BaseService, IEmployeeService
    {
        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>新增結果</returns>
        public bool Add(EmployeeBO employeeBO)
        {
            EmployeeDO employeeDO = ConvertUtil.ToObject<EmployeeDO>(employeeBO);
            return _employeeDAO.Add(employeeDO);
        }
    }
}
