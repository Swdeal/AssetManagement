using AssetManagement.Core.Models.BusinessObject.Emploee;
using AssetManagement.Core.Models.DataObject.Employee;
using AssetManagement.Core.Service.Interface;
using Lib.Constant;
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
        /// 
        /// </summary>
        /// <param name="employeeBO"></param>
        /// <returns></returns>
        public bool Edit(EmployeeBO employeeBO)
        {
            EmployeeDO employeeDO = _employeeDAO.GetEmployee(employeeBO.EmployeeUID!);

            employeeDO.EmployeePWD = employeeBO.EmployeePWD;
            employeeDO.EmployeeName = employeeBO.EmployeeName;
            employeeDO.EmployeeEmail = employeeBO.EmployeeEmail;
            employeeDO.ModifyUser = Constant.DEFAULT_USER;
            employeeDO.ModifyTime = DateTimeOffset.Now;

            return _employeeDAO.Edit(employeeDO);
        }
    }
}
